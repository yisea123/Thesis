#include "SRF05.h"

volatile float f_front_dis = 0.0f;
volatile float f_rear_dis = 0.0f;
volatile float f_grip_dis = 0.0f;

void SRF05_Init(void)
{
	/*
		PC10			TRIG_FRONT    TIM9
		PA2				ECHO_FRONT
		PC11			TRIG REAR			TIM11
		PA3				ECHO REAR
		PC12			TRIG GRIPPER	TIM12
		PA5				ECHO GRIPPER
	*/
	GPIO_InitTypeDef GPIO_InitStructure;
	TIM_TimeBaseInitTypeDef TIM_BaseStruct;
	EXTI_InitTypeDef EXTI_InitStruct;
  NVIC_InitTypeDef NVIC_InitStruct;
	
	RCC_AHB1PeriphClockCmd(RCC_AHB1Periph_GPIOA | RCC_AHB1Periph_GPIOC, ENABLE);
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_SYSCFG, ENABLE);
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM12, ENABLE);
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_TIM9 | RCC_APB2Periph_TIM11, ENABLE);
	
	GPIO_InitStructure.GPIO_Pin 	= GPIO_Pin_10 | GPIO_Pin_11 | GPIO_Pin_12;
	GPIO_InitStructure.GPIO_Mode  = GPIO_Mode_OUT;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_100MHz;
	GPIO_InitStructure.GPIO_OType = GPIO_OType_PP;
	GPIO_InitStructure.GPIO_PuPd  = GPIO_PuPd_NOPULL;
	GPIO_Init(GPIOC, &GPIO_InitStructure);
	
	GPIO_InitStructure.GPIO_Pin 	= GPIO_Pin_2 | GPIO_Pin_3 | GPIO_Pin_5;
	GPIO_InitStructure.GPIO_Mode  = GPIO_Mode_IN;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_100MHz;
	GPIO_InitStructure.GPIO_OType = GPIO_OType_PP;
	GPIO_InitStructure.GPIO_PuPd  = GPIO_PuPd_NOPULL;
	GPIO_Init(GPIOA, &GPIO_InitStructure);
	
	SYSCFG_EXTILineConfig(EXTI_PortSourceGPIOA, EXTI_PinSource2);
	 
	EXTI_InitStruct.EXTI_Line = EXTI_Line2;
	EXTI_InitStruct.EXTI_LineCmd = ENABLE;
	EXTI_InitStruct.EXTI_Mode = EXTI_Mode_Interrupt;
	EXTI_InitStruct.EXTI_Trigger = EXTI_Trigger_Rising_Falling;
	EXTI_Init(&EXTI_InitStruct);
	 
	NVIC_InitStruct.NVIC_IRQChannel = EXTI2_IRQn;
	NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = 1;
	NVIC_InitStruct.NVIC_IRQChannelSubPriority = 1;
	NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;
	NVIC_Init(&NVIC_InitStruct);
	
	SYSCFG_EXTILineConfig(EXTI_PortSourceGPIOA, EXTI_PinSource3);
	
	EXTI_InitStruct.EXTI_Line = EXTI_Line3;
	EXTI_InitStruct.EXTI_LineCmd = ENABLE;
	EXTI_InitStruct.EXTI_Mode = EXTI_Mode_Interrupt;
	EXTI_InitStruct.EXTI_Trigger = EXTI_Trigger_Rising_Falling;
	EXTI_Init(&EXTI_InitStruct);
	 
	NVIC_InitStruct.NVIC_IRQChannel = EXTI3_IRQn;
	NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = 2;
	NVIC_InitStruct.NVIC_IRQChannelSubPriority = 2;
	NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;
	NVIC_Init(&NVIC_InitStruct);
	
	SYSCFG_EXTILineConfig(EXTI_PortSourceGPIOA, EXTI_PinSource5);
	
	EXTI_InitStruct.EXTI_Line = EXTI_Line5;
	EXTI_InitStruct.EXTI_LineCmd = ENABLE;
	EXTI_InitStruct.EXTI_Mode = EXTI_Mode_Interrupt;
	EXTI_InitStruct.EXTI_Trigger = EXTI_Trigger_Rising_Falling;
	EXTI_Init(&EXTI_InitStruct);
		 
	NVIC_InitStruct.NVIC_IRQChannel = EXTI9_5_IRQn;
	NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = 3;
	NVIC_InitStruct.NVIC_IRQChannelSubPriority = 3;
	NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;
	NVIC_Init(&NVIC_InitStruct);
	

	TIM_BaseStruct.TIM_Prescaler = 9;		///////////////////////////////
	TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;
	TIM_BaseStruct.TIM_Period = 0xffffffff - 1;		//////////////////////////
	TIM_BaseStruct.TIM_ClockDivision = TIM_CKD_DIV1;
	TIM_BaseStruct.TIM_RepetitionCounter = 0;
	TIM_TimeBaseInit(TIM9, &TIM_BaseStruct);
	TIM_Cmd(TIM9, DISABLE);
	
	TIM_BaseStruct.TIM_Prescaler = 9;		//////////////////////////
	TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;
	TIM_BaseStruct.TIM_Period = 0xffffffff - 1;		/////////////////////////////
	TIM_BaseStruct.TIM_ClockDivision = TIM_CKD_DIV1;
	TIM_BaseStruct.TIM_RepetitionCounter = 0;
	TIM_TimeBaseInit(TIM11, &TIM_BaseStruct);
	TIM_Cmd(TIM11, DISABLE);
	
	TIM_BaseStruct.TIM_Prescaler = 4;		/////////////////////////////
	TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;
	TIM_BaseStruct.TIM_Period = 0xffffffff - 1;		//////////////////////////////
	TIM_BaseStruct.TIM_ClockDivision = TIM_CKD_DIV1;
	TIM_BaseStruct.TIM_RepetitionCounter = 0;
	TIM_TimeBaseInit(TIM12, &TIM_BaseStruct);
	TIM_Cmd(TIM12, DISABLE);	
}


void write_SRF05_trigger(SRF05_SENSOR_ENUM e_sensor)
{
	switch((int)e_sensor)
	{
		case FRONT_SRF05:
		{
			GPIO_SetBits(GPIOC, GPIO_Pin_10);
			delay_us(12);
			GPIO_ResetBits(GPIOC, GPIO_Pin_10);
			break;
		}
		case REAR_SRF05:
		{
			GPIO_SetBits(GPIOC, GPIO_Pin_11);
			delay_us(12);
			GPIO_ResetBits(GPIOC, GPIO_Pin_11);
			break;
		}
		case GRIPPER_SRF05:
		{
			GPIO_SetBits(GPIOC, GPIO_Pin_12);
			delay_us(12);
			GPIO_ResetBits(GPIOC, GPIO_Pin_12);
			break;
		}
	}
}


void EXTI2_IRQHandler(void) 
{
	if(EXTI_GetITStatus(EXTI_Line2) != RESET) 
	{
		if(GPIO_ReadInputDataBit(GPIOA, GPIO_Pin_2)==Bit_SET)
		{
			TIM_Cmd(TIM9, ENABLE);
		}
		else
		{
			f_front_dis = (float)(TIM_GetCounter(TIM9))*d_Time_per_count_SRF05*d_Sound_Speed_SRF05*100.0f*0.5f;					
			TIM_Cmd(TIM9, DISABLE);
			TIM_SetCounter(TIM9, 0);
		}
		EXTI_ClearITPendingBit(EXTI_Line2);
  }
}

void EXTI3_IRQHandler(void) 
{
	if(EXTI_GetITStatus(EXTI_Line3) != RESET) 
	{
		if(GPIO_ReadInputDataBit(GPIOA, GPIO_Pin_3)==Bit_SET)
		{
			TIM_Cmd(TIM11, ENABLE);
		}
		else
		{
		  f_rear_dis = (float)(TIM_GetCounter(TIM11))*d_Time_per_count_SRF05*d_Sound_Speed_SRF05*100.0f*0.5f;
			TIM_Cmd(TIM11, DISABLE);
			TIM_SetCounter(TIM11, 0);
		}
		EXTI_ClearITPendingBit(EXTI_Line3);
  }
}

void EXTI9_5_IRQHandler(void) 
{
	if(EXTI_GetITStatus(EXTI_Line5) != RESET) 
	{
		if(GPIO_ReadInputDataBit(GPIOA, GPIO_Pin_5)==Bit_SET)
		{
			TIM_Cmd(TIM12, ENABLE);
		}
		else
		{
			f_grip_dis = (float)(TIM_GetCounter(TIM12))*d_Time_per_count_SRF05*d_Sound_Speed_SRF05*100.0f*0.5f;
			TIM_Cmd(TIM12, DISABLE);
			TIM_SetCounter(TIM12, 0);
		}
		EXTI_ClearITPendingBit(EXTI_Line5);
  }
}

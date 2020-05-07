#include "stm32f4xx.h"
#include "system_timetick.h"
#include "string.h"
#include "MOTOR.h"

void MOTOR_GPIO_Init(void)
{
	GPIO_InitTypeDef GPIO_InitStruct;
  /* Clock for GPIOD */
	RCC_AHB1PeriphClockCmd(RCC_AHB1Periph_GPIOA | RCC_AHB1Periph_GPIOB | RCC_AHB1Periph_GPIOE, ENABLE);


	/* Alternating functions for pins */
	GPIO_PinAFConfig(GPIOA, GPIO_PinSource6, GPIO_AF_TIM13);		//Motor_3 pulse (Joint3)
	GPIO_PinAFConfig(GPIOA, GPIO_PinSource7, GPIO_AF_TIM14);		//Motor_4 pulse (Gripper)
	GPIO_PinAFConfig(GPIOB, GPIO_PinSource8, GPIO_AF_TIM10);		//Motor_1 pulse (Joint1)
	GPIO_PinAFConfig(GPIOB, GPIO_PinSource9, GPIO_AF_TIM11);		//Motor_2 pulse (Joint2)
	GPIO_PinAFConfig(GPIOE, GPIO_PinSource5, GPIO_AF_TIM9);		//Motor_5 pulse	(Left wheel)
	GPIO_PinAFConfig(GPIOE, GPIO_PinSource6, GPIO_AF_TIM9);		//Motor_6 pulse (Right wheel)
	
	
	/* Set pins on port A, port B, port E */
	
	GPIO_InitStruct.GPIO_Pin = GPIO_Pin_6 | GPIO_Pin_7;
	GPIO_InitStruct.GPIO_OType = GPIO_OType_PP;
	GPIO_InitStruct.GPIO_PuPd = GPIO_PuPd_NOPULL;
	GPIO_InitStruct.GPIO_Mode = GPIO_Mode_AF;
	GPIO_InitStruct.GPIO_Speed = GPIO_Speed_100MHz;
	GPIO_Init(GPIOA, &GPIO_InitStruct);
	
	GPIO_InitStruct.GPIO_Pin = GPIO_Pin_8 | GPIO_Pin_9;
	GPIO_InitStruct.GPIO_OType = GPIO_OType_PP;
	GPIO_InitStruct.GPIO_PuPd = GPIO_PuPd_NOPULL;
	GPIO_InitStruct.GPIO_Mode = GPIO_Mode_AF;
	GPIO_InitStruct.GPIO_Speed = GPIO_Speed_100MHz;
	GPIO_Init(GPIOB, &GPIO_InitStruct);
	
	GPIO_InitStruct.GPIO_Pin = GPIO_Pin_5 | GPIO_Pin_6;
	GPIO_InitStruct.GPIO_OType = GPIO_OType_PP;
	GPIO_InitStruct.GPIO_PuPd = GPIO_PuPd_NOPULL;
	GPIO_InitStruct.GPIO_Mode = GPIO_Mode_AF;
	GPIO_InitStruct.GPIO_Speed = GPIO_Speed_100MHz;
	GPIO_Init(GPIOE, &GPIO_InitStruct);
}

void MOTOR_PWM_Joint_Init(JOINT_ENUM e_joint)
{
	TIM_TimeBaseInitTypeDef TIM_BaseStruct;
		
	TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;
	//TIM_BaseStruct.TIM_Period = 839;
	TIM_BaseStruct.TIM_ClockDivision = TIM_CKD_DIV1;
	TIM_BaseStruct.TIM_RepetitionCounter = 0;
		
	TIM_OCInitTypeDef TIM_OCStruct;
      
	TIM_OCStruct.TIM_OCMode = TIM_OCMode_PWM2;
	TIM_OCStruct.TIM_OutputState = TIM_OutputState_Enable;
	TIM_OCStruct.TIM_OCPolarity = TIM_OCPolarity_Low;
	TIM_OCStruct.TIM_Pulse = 0;
	
	
	if(e_joint == JOINT_1)
	{
		RCC_APB2PeriphClockCmd(RCC_APB2Periph_TIM10, ENABLE);
		TIM_BaseStruct.TIM_Prescaler = 3;
		TIM_TimeBaseInit(TIM10, &TIM_BaseStruct);
		TIM_Cmd(TIM10, DISABLE);
		TIM_OC1Init(TIM10, &TIM_OCStruct);
		TIM_OC1PreloadConfig(TIM10, TIM_OCPreload_Enable);
	}
	else if(e_joint == JOINT_2)
	{
		RCC_APB2PeriphClockCmd(RCC_APB2Periph_TIM11, ENABLE);
		TIM_BaseStruct.TIM_Prescaler = 3;
		TIM_TimeBaseInit(TIM11, &TIM_BaseStruct);
		TIM_Cmd(TIM11, DISABLE);
		TIM_OC1Init(TIM11, &TIM_OCStruct);
		TIM_OC1PreloadConfig(TIM11, TIM_OCPreload_Enable);
	}
	else if(e_joint == JOINT_3)
	{
		RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM13, ENABLE);
		TIM_BaseStruct.TIM_Prescaler = 1;
		TIM_TimeBaseInit(TIM13, &TIM_BaseStruct);
		TIM_Cmd(TIM13, DISABLE);
		TIM_OC1Init(TIM13, &TIM_OCStruct);
		TIM_OC1PreloadConfig(TIM13, TIM_OCPreload_Enable);
	}
}

void MOTOR_PWM_Gripper_Init(void)
{
	TIM_TimeBaseInitTypeDef TIM_BaseStruct;
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM14, ENABLE);

	TIM_BaseStruct.TIM_Prescaler = 199;
	TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;
	TIM_BaseStruct.TIM_Period = 8399;
	TIM_BaseStruct.TIM_ClockDivision = TIM_CKD_DIV1;
	TIM_BaseStruct.TIM_RepetitionCounter = 0;
	TIM_TimeBaseInit(TIM14, &TIM_BaseStruct);
	TIM_Cmd(TIM14, DISABLE);
	
	TIM_OCInitTypeDef TIM_OCStruct;
  
	TIM_OCStruct.TIM_OCMode = TIM_OCMode_PWM2;
	TIM_OCStruct.TIM_OutputState = TIM_OutputState_Enable;
	TIM_OCStruct.TIM_OCPolarity = TIM_OCPolarity_Low;	
	TIM_OCStruct.TIM_Pulse = 0;
	TIM_OC1Init(TIM14, &TIM_OCStruct);
	TIM_OC1PreloadConfig(TIM14, TIM_OCPreload_Enable);
}

void MOTOR_PWM_Wheel_Init(void)
{
	TIM_TimeBaseInitTypeDef TIM_BaseStruct;
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_TIM9, ENABLE);

	TIM_BaseStruct.TIM_Prescaler = 1;
	TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;
	TIM_BaseStruct.TIM_Period = 8399;
	TIM_BaseStruct.TIM_ClockDivision = TIM_CKD_DIV1;
	TIM_BaseStruct.TIM_RepetitionCounter = 0;
	TIM_TimeBaseInit(TIM9, &TIM_BaseStruct);
	TIM_Cmd(TIM9, DISABLE);
	
	TIM_OCInitTypeDef TIM_OCStruct;
  
	TIM_OCStruct.TIM_OCMode = TIM_OCMode_PWM2;
	TIM_OCStruct.TIM_OutputState = TIM_OutputState_Enable;
	TIM_OCStruct.TIM_OCPolarity = TIM_OCPolarity_Low;	
	
	TIM_OCStruct.TIM_Pulse = 0;
	TIM_OC1Init(TIM9, &TIM_OCStruct);
	TIM_OC1PreloadConfig(TIM9, TIM_OCPreload_Enable);
	
	TIM_OCStruct.TIM_Pulse = 0;
	TIM_OC2Init(TIM9, &TIM_OCStruct);
	TIM_OC2PreloadConfig(TIM9, TIM_OCPreload_Enable);
}
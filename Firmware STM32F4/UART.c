#include "UART.h"

uint8_t ui8_dma_rx_buff[DMA_RX_BUFF_SIZE] = {0};
uint8_t ui8_dma_tx_buff[DMA_TX_BUFF_SIZE] = {0};

//uint32_t len = 0;
int32_t temp;
uint8_t frame[USR_TX_BUFF_SIZE] = {0};

extern float f_theta1;
extern float f_theta2;
extern float f_theta3;

extern volatile float f_front_dis;
extern volatile float f_rear_dis;
extern volatile float f_grip_dis;


extern float f_left_vel_fil;
extern float f_right_vel_fil;
extern float f_setpoint_left_vel_fil;
extern float f_setpoint_right_vel_fil;
extern float f_setpoint_left_vel;
extern float f_setpoint_right_vel;

void UART_USR_Init(void)
{
	GPIO_InitTypeDef 		GPIO_InitStructure;
	USART_InitTypeDef 	USART_InitStructure;   
	DMA_InitTypeDef  		DMA_InitStructure;
	NVIC_InitTypeDef  	NVIC_InitStructure;
	TIM_TimeBaseInitTypeDef TIM_BaseStruct;
	
	//Clock enable
	RCC_AHB1PeriphClockCmd(RCC_AHB1Periph_GPIOA | RCC_AHB1Periph_DMA1, ENABLE);
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_UART4, ENABLE);
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM2, ENABLE);
	
	
	TIM_BaseStruct.TIM_Prescaler = 4;
	TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;
	TIM_BaseStruct.TIM_Period = 0xffffffff - 1;									
	TIM_BaseStruct.TIM_ClockDivision = TIM_CKD_DIV1;
	TIM_BaseStruct.TIM_RepetitionCounter = 0;
	TIM_TimeBaseInit(TIM2, &TIM_BaseStruct);
	TIM_Cmd(TIM2, DISABLE);
	
	
	//Pin PA0, PA1 config 
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_0 | GPIO_Pin_1;
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF;
	GPIO_InitStructure.GPIO_OType = GPIO_OType_PP;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_100MHz;
	GPIO_InitStructure.GPIO_PuPd = GPIO_PuPd_UP;
	GPIO_Init(GPIOA, &GPIO_InitStructure);
	
	//Set alternate function
	GPIO_PinAFConfig(GPIOA, GPIO_PinSource0, GPIO_AF_UART4);  
	GPIO_PinAFConfig(GPIOA, GPIO_PinSource1, GPIO_AF_UART4);
	
	
	/* USARTx configured as follow:
		- BaudRate = 115200 baud  
    - Word Length = 8 Bits
    - One Stop Bit
    - No parity
    - Hardware flow control disabled (RTS and CTS signals)
    - Receive and transmit enabled
  */
  USART_InitStructure.USART_BaudRate = 115200;
  USART_InitStructure.USART_WordLength = USART_WordLength_8b;
  USART_InitStructure.USART_StopBits = USART_StopBits_1;
  USART_InitStructure.USART_Parity = USART_Parity_No;
  USART_InitStructure.USART_HardwareFlowControl = USART_HardwareFlowControl_None;
  USART_InitStructure.USART_Mode = USART_Mode_Rx | USART_Mode_Tx;
	USART_Init(UART4, &USART_InitStructure);
	
	/* Enable USART */
  USART_Cmd(UART4, ENABLE);	
	USART_ClearFlag(UART4, USART_FLAG_TC);
	
	/* Enable UART4 DMA */
  USART_DMACmd(UART4, USART_DMAReq_Tx, ENABLE); 
	USART_DMACmd(UART4, USART_DMAReq_Rx, ENABLE);	
	
	/* DMA1 Stream4 Channel4 for UART4 Tx configuration */			
  DMA_InitStructure.DMA_Channel = DMA_Channel_4;  
  DMA_InitStructure.DMA_PeripheralBaseAddr = (uint32_t)&UART4->DR;
  DMA_InitStructure.DMA_Memory0BaseAddr = (uint32_t)ui8_dma_tx_buff;
  DMA_InitStructure.DMA_DIR = DMA_DIR_MemoryToPeripheral;
  DMA_InitStructure.DMA_BufferSize = 0;//DMA_TX_BUFF_SIZE;
  DMA_InitStructure.DMA_PeripheralInc = DMA_PeripheralInc_Disable;
  DMA_InitStructure.DMA_MemoryInc = DMA_MemoryInc_Enable;
  DMA_InitStructure.DMA_PeripheralDataSize = DMA_PeripheralDataSize_Byte;
  DMA_InitStructure.DMA_MemoryDataSize = DMA_MemoryDataSize_Byte;
  DMA_InitStructure.DMA_Mode = DMA_Mode_Normal;
  DMA_InitStructure.DMA_Priority = DMA_Priority_Low;
  DMA_InitStructure.DMA_FIFOMode = DMA_FIFOMode_Disable;         
  DMA_InitStructure.DMA_FIFOThreshold = DMA_FIFOThreshold_HalfFull;
  DMA_InitStructure.DMA_MemoryBurst = DMA_MemoryBurst_Single;
  DMA_InitStructure.DMA_PeripheralBurst = DMA_PeripheralBurst_Single;
  DMA_Init(DMA1_Stream4, &DMA_InitStructure);
  DMA_Cmd(DMA1_Stream4, ENABLE);
		
	/* DMA1 Stream2 Channel4 for USART4 Rx configuration */			
  DMA_InitStructure.DMA_Channel = DMA_Channel_4;  
  DMA_InitStructure.DMA_PeripheralBaseAddr = (uint32_t)&UART4->DR;
  DMA_InitStructure.DMA_Memory0BaseAddr = (uint32_t)ui8_dma_rx_buff;
  DMA_InitStructure.DMA_DIR = DMA_DIR_PeripheralToMemory;
  DMA_InitStructure.DMA_BufferSize = DMA_RX_BUFF_SIZE;
  DMA_InitStructure.DMA_PeripheralInc = DMA_PeripheralInc_Disable;
  DMA_InitStructure.DMA_MemoryInc = DMA_MemoryInc_Enable;
  DMA_InitStructure.DMA_PeripheralDataSize = DMA_PeripheralDataSize_Byte;
  DMA_InitStructure.DMA_MemoryDataSize = DMA_MemoryDataSize_Byte;
  DMA_InitStructure.DMA_Mode = DMA_Mode_Circular;
  DMA_InitStructure.DMA_Priority = DMA_Priority_VeryHigh;
  DMA_InitStructure.DMA_FIFOMode = DMA_FIFOMode_Disable;         
  DMA_InitStructure.DMA_FIFOThreshold = DMA_FIFOThreshold_HalfFull; //DMA_FIFOThreshold_Full;
  DMA_InitStructure.DMA_MemoryBurst = DMA_MemoryBurst_Single;
  DMA_InitStructure.DMA_PeripheralBurst = DMA_PeripheralBurst_Single;
  DMA_Init(DMA1_Stream2, &DMA_InitStructure);
  DMA_Cmd(DMA1_Stream2, ENABLE);
		
	/* Enable DMA Interrupt to the highest priority */
  NVIC_InitStructure.NVIC_IRQChannel = DMA1_Stream2_IRQn;
  NVIC_InitStructure.NVIC_IRQChannelPreemptionPriority = 0;
  NVIC_InitStructure.NVIC_IRQChannelSubPriority = 0;
  NVIC_InitStructure.NVIC_IRQChannelCmd = ENABLE;
  NVIC_Init(&NVIC_InitStructure);
	
	DMA_ITConfig(DMA1_Stream2, DMA_IT_TC, ENABLE);
	
}


void UART_USR_Send(uint8_t *ui8_data, uint32_t ui32_data_cnt)
{
	DMA_Cmd(DMA1_Stream4, DISABLE);
	memcpy(ui8_dma_tx_buff, ui8_data, ui32_data_cnt);
	DMA_ClearFlag(DMA1_Stream4, DMA_FLAG_TCIF4);
	DMA1_Stream4->NDTR = ui32_data_cnt;
	DMA_Cmd(DMA1_Stream4, ENABLE);
}

void UART_USR_Send_Vel(float time)//second
{
	uint8_t str[3] = "vel";	
	memcpy(&frame[0], str, 3);
	IntToStr_len((int32_t)(f_left_vel_fil*10), &frame[3], 5);
	IntToStr_len((int32_t)(f_right_vel_fil*10), &frame[8], 5);
//	IntToStr_len((int32_t)(f_setpoint_left_vel_fil*10), &frame[13], 5);
//	IntToStr_len((int32_t)(f_setpoint_right_vel_fil*10), &frame[18], 5);
//	IntToStr_len((int32_t)(f_setpoint_left_vel*10), &frame[23], 5);
//	IntToStr_len((int32_t)(f_setpoint_right_vel*10), &frame[28], 5);
	IntToStr_len((int32_t)(time*1000), &frame[13], 7);
	float temp = 0.0f;
	uint8_t str2[3] = "arm";
	memcpy(&frame[20], str2, 3);
	IntToStr_len((int32_t)(f_theta1*100), &frame[23], 6);
	IntToStr_len((int32_t)(f_theta2*100), &frame[29], 6);
	IntToStr_len((int32_t)(f_theta3*100), &frame[35], 6);
	temp = 15.5f*cosf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f);
	IntToStr_len((int32_t)(temp*100), &frame[41], 6);
	temp = -15.5f*sinf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f) - 20.0f;
	IntToStr_len((int32_t)(temp*100), &frame[47], 6);
	temp = 15.5f*sinf(f_theta2*-PI/180.0f) + 8.0f;
	IntToStr_len((int32_t)(temp*100), &frame[53], 6);
	temp = 15.5f*cosf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f) 
				+11.5f*cosf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f)*cosf(f_theta3*-PI/180.0f)
				-11.5f*cosf((- f_theta1 + 20)*-PI/180.0f)*sinf(f_theta2*-PI/180.0f)*sinf(f_theta3*-PI/180.0f);
	IntToStr_len((int32_t)(temp*100), &frame[59], 6);
	temp = -15.5f*sinf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f) - 20.0f
				-11.5f*sinf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f)*cosf(f_theta3*-PI/180.0f)
				+11.5f*sinf((- f_theta1 + 20)*-PI/180.0f)*sinf(f_theta2*-PI/180.0f)*sinf(f_theta3*-PI/180.0f);
	IntToStr_len((int32_t)(temp*100), &frame[65], 6);
	temp = 15.5f*sinf(f_theta2*-PI/180.0f) + 8.0f
			  +11.5f*sinf(f_theta2*-PI/180.0f)*cosf(f_theta3*-PI/180.0f)
				+11.5f*cosf(f_theta2*-PI/180.0f)*sinf(f_theta3*-PI/180.0f);
	IntToStr_len((int32_t)(temp*100), &frame[71], 6);
	frame[77]='\r';
	frame[78]='\n';
	UART_USR_Send((uint8_t*)frame, 79);
	
}

void UART_USR_Send_Arm_Para(void)
{
	float temp = 0.0f;
	uint8_t str[3] = "arm";
	memcpy(&frame[0], str, 3);
	IntToStr_len((int32_t)(f_theta1*100), &frame[3], 6);
	IntToStr_len((int32_t)(f_theta2*100), &frame[9], 6);
	IntToStr_len((int32_t)(f_theta3*100), &frame[15], 6);
	temp = 15.5f*cosf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f);
	IntToStr_len((int32_t)(temp*100), &frame[21], 6);
	temp = -15.5f*sinf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f) - 20.0f;
	IntToStr_len((int32_t)(temp*100), &frame[27], 6);
	temp = 15.5f*sinf(f_theta2*-PI/180.0f) + 8.0f;
	IntToStr_len((int32_t)(temp*100), &frame[33], 6);
	temp = 15.5f*cosf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f) 
				+11.5f*cosf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f)*cosf(f_theta3*-PI/180.0f)
				-11.5f*cosf((- f_theta1 + 20)*-PI/180.0f)*sinf(f_theta2*-PI/180.0f)*sinf(f_theta3*-PI/180.0f);
	IntToStr_len((int32_t)(temp*100), &frame[39], 6);
	temp = -15.5f*sinf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f) - 20.0f
				-11.5f*sinf((- f_theta1 + 20)*-PI/180.0f)*cosf(f_theta2*-PI/180.0f)*cosf(f_theta3*-PI/180.0f)
				+11.5f*sinf((- f_theta1 + 20)*-PI/180.0f)*sinf(f_theta2*-PI/180.0f)*sinf(f_theta3*-PI/180.0f);
	IntToStr_len((int32_t)(temp*100), &frame[45], 6);
	temp = 15.5f*sinf(f_theta2*-PI/180.0f) + 8.0f
			  +11.5f*sinf(f_theta2*-PI/180.0f)*cosf(f_theta3*-PI/180.0f)
				+11.5f*cosf(f_theta2*-PI/180.0f)*sinf(f_theta3*-PI/180.0f);
	IntToStr_len((int32_t)(temp*100), &frame[51], 6);
	frame[58]='\r';
	frame[59]='\n';
	UART_USR_Send((uint8_t*)frame, 60);
}

void UART_USR_Send_ACK(bool IsStart)
{
//	uint8_t str1[11] = "ACK Start\r\n";
//	uint8_t str2[10] = "ACK Stop\r\n";
//	if(IsStart == true)
//	{
//		UART_USR_Send((uint8_t*)str1, 11);
//	}
//	else
//	{
//		UART_USR_Send((uint8_t*)str2, 10);
//	}
}

void UART_USR_Send_SRF05_Distance(void)
{
	write_SRF05_trigger(GRIPPER_SRF05);
	uint8_t str[3] = "dis";
	memcpy(&frame[0], str, 3);
	IntToStr_len((int32_t)(f_grip_dis*10), &frame[3], 6);
	frame[10]='\r';
	frame[11]='\n';
	UART_USR_Send((uint8_t*)frame, 12);
	
}

void DMA1_Stream2_IRQHandler(void)
{	
  /* Clear the DMA1_Stream2 TCIF2 pending bit */
  DMA_ClearITPendingBit(DMA1_Stream2, DMA_IT_TCIF2);
	TIM_Cmd(TIM2, DISABLE);
	TIM_SetCounter(TIM2, 0);
	TIM_Cmd(TIM2, ENABLE);
	DMA_Cmd(DMA1_Stream2, ENABLE);
}	





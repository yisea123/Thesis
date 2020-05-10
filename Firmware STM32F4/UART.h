#ifndef _UART_H
#define _UART_H

#include "stm32f4xx.h"
#include "CONTROL.h"
#include "string.h"
#include "PWM.h"
#include "utils.h"
#include "stdbool.h"
#include "define.h"
#include "SRF05.h"


//#define USR_RX_BUFF_SIZE 				64
#define USR_TX_BUFF_SIZE 				100
#define DMA_RX_BUFF_SIZE				24
#define DMA_TX_BUFF_SIZE				64

void UART_USR_Init(void);
void UART_USR_Send(uint8_t *ui8_data, uint32_t ui32_data_cnt);
void UART_USR_Send_SRF05_Distance(void);
void UART_USR_Send_Arm_Para(void);
void UART_USR_Send_Vel(float time);
void UART_USR_Send_ACK(bool IsStart);
#endif

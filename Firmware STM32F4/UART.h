#ifndef UART_H
#define UART_H

#include <stdint.h>
//#include <stdbool.h>

//#define USR_RX_BUFF_SIZE 				64
#define USR_TX_BUFF_SIZE 				11

#define DMA_RX_BUFF_SIZE				5
#define DMA_TX_BUFF_SIZE				11


void UART_USR_Init(void);
void UART_USR_Send(uint8_t *ui8_data, uint32_t ui32_data_cnt);
void UART_USR_Send_ENC_Counter(void);



#endif

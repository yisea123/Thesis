#ifndef _FSMC_H
#define _FSMC_H

#include "system_timetick.h"


#define d_Pulse_Base_ADDR 				0x60000000
#define d_ENC_Base_ADDR 					0x60000020

void FSMC_Write(uint32_t ui_address, uint32_t ui_data);
uint16_t FSMC_Read(uint32_t ui_enc_channel);
void FSMC_Init(void);


#endif


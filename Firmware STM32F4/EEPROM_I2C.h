#ifndef __EEPROM_I2C_H
#define __EEPROM_I2C_H

#include <stdint.h>
#include <stdbool.h>

#define I2C_TIMEOUT           100000
////Note: EEPROM AT24C04 address is 8 bits:|1010|A2|A1|Page|R/W|
#define EEP_ADD               0xA0
#define EEP_PAGE_0            0x00
#define EEP_PAGE_1            0x02

bool EEP_WriteBytes(uint8_t* c, uint16_t r, uint16_t l);
bool EEP_ReadBytes(uint8_t* c, uint16_t r, uint16_t l);
void EEP_Init(void);




#endif

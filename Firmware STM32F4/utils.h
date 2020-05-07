#ifndef _UTILS_H
#define _UTILS_H

#include <stdbool.h>
#include <stdint.h>


void IntToStr_len(int32_t u, uint8_t *y, uint8_t len);
void delay_01ms(uint16_t period);
void delay_us(uint16_t period);
void my_delay_us(uint32_t micros);

#endif


#include <stdint.h>
#include <math.h>
#include "utils.h"
#include "stm32f4xx.h"


void IntToStr_len(int32_t u, uint8_t *y, uint8_t len)
{
	int32_t a;
	a = u;
	if (a<0)
	{ 
		a = -a; 
		y[0] = '-';
	}
	else y[0] = ' ';
	
	for (int i = 1; i < len; i++)
	{
		y[len - i] = a % 10 + 0x30;
		a = a / 10;
	}
}

void delay_01ms(uint16_t period)
{

  	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM6, ENABLE);
  	TIM6->PSC = 8399;		// clk = SystemCoreClock / 4 / (PSC+1) *2 = 10KHz
  	TIM6->ARR = period-1;
  	TIM6->CNT = 0;
  	TIM6->EGR = 1;		// update registers;

  	TIM6->SR  = 0;		// clear overflow flag
  	TIM6->CR1 = 1;		// enable Timer6

  	while (!TIM6->SR);
    
  	TIM6->CR1 = 0;		// stop Timer6
  	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM6, DISABLE);
}

void delay_us(uint16_t period)
{

  	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM6, ENABLE);
  	TIM6->PSC = 83;		// clk = SystemCoreClock / 4 / (PSC+1) *2 = 1MHz
  	TIM6->ARR = period-1;
  	TIM6->CNT = 0;
  	TIM6->EGR = 1;		// update registers;

  	TIM6->SR  = 0;		// clear overflow flag
  	TIM6->CR1 = 1;		// enable Timer6

  	while (!TIM6->SR);
    
  	TIM6->CR1 = 0;		// stop Timer6
  	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM6, DISABLE);
}

void my_delay_us(uint32_t micros)
{
	RCC_ClocksTypeDef RCC_Clocks;	
	/* Get system clocks */
	RCC_GetClocksFreq(&RCC_Clocks);	
	micros = micros * (RCC_Clocks.HCLK_Frequency / 4000000) - 10;
  /* 4 cycles for one loop */
	while (micros--);
}


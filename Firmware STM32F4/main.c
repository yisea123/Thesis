#include "stm32f4xx.h"
#include "system_timetick.h"
#include "UART.h"
#include "GPIO.h"
#include "utils.h"

uint8_t cnt = 0;
int32_t counter = 0;
float pos = 0;
float vel = 0;
int i =0;

int main(void)
{
	
	SysTick_Config(SystemCoreClock / 1000);
	
	UART_USR_Init();

	
	while(1){		
			if(tick_flag)
			{			
				cnt++;
				if (cnt == 200)
				{
														
					cnt = 0;
					
				}				
				tick_flag = 0;			
			}							
	}	
}








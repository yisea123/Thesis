#include "UART.h"
#include "EEPROM_I2C.h"
#include "GPIO.h"
#include "SRF05.h"
#include "define.h"
#include "CONTROL.h"

uint16_t cnt = 0;
//uint8_t cnt2 = 0;
float process_time = 0.1f;

int main(void)
{
	SysTick_Config(SystemCoreClock / 1000);
	EEP_Init();
	IO_Init();
	SRF05_Init();
	PWM_Gripper_Init();
	PWM_Left_Wheel_Init();
	PWM_Right_Wheel_Init();
	FSMC_Init();
	ARM_Servo_Move_To_Defined_Home_Start();
	UART_USR_Init();	
	delay_01ms(1000);	
	while(1)
		{					
			if(tick_flag)
			{
				cnt++;
				if(cnt == 300)
				{
						UART_USR_Send_Vel(process_time);
						process_time+=0.3f;	
					cnt=0;
				}	

				
				if(Is_Connection_Timeout(0.25) == true)		//sencond
				{
					Stop_Process();		
				}
				System_Process();						
				tick_flag = 0;
				
						
			}							
		}	
}








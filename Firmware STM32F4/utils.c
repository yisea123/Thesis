#include "utils.h"

extern float max_rpm_left;
extern float max_rpm_right;

void Cal_Arm_Num_Pulse(float f_X_Axis, float f_Y_Axis, uint8_t speed_mode, int32_t *i_Arm_Num_Pulse)
{
	float temp = (f_Y_Axis/100.0f)*d_Arm_Max_Pulse_Per_Period;
	if(speed_mode == 'L')
	{
		temp = temp/2;
	}
	*i_Arm_Num_Pulse = (int32_t)temp;
}

void Cal_Gripper_Pulse_Width(float f_X_Axis, float f_Y_Axis, uint8_t speed_mode, float *f_Gripper_Pulse_Width)
{
	float temp = f_Y_Axis;
	if(speed_mode == 'L')
	{
		temp = temp/2;
	}
	*f_Gripper_Pulse_Width = temp;	
}


void Cal_Test_Wheel_Speed_Setpoint(uint8_t *ui_Right_SetPoint, uint8_t *ui_Left_SetPoint, uint8_t speed_mode, float *f_Right_Speed_Setpoint, float *f_Left_Speed_Setpoint)
{
	float tempR, tempL;
	tempL = StrToFloat_PID_SetPoint(&ui_Left_SetPoint[0]);
	tempR = StrToFloat_PID_SetPoint(&ui_Right_SetPoint[0]);
	if(speed_mode == 'L')
	{
		tempL = tempL/2.0f;;
		tempR = tempR/2.0f;;
	}
	*f_Right_Speed_Setpoint = tempR;
	*f_Left_Speed_Setpoint = tempL;	
}

void Cal_Wheel_Speed_Setpoint(float f_X_Axis, float f_Y_Axis, uint8_t speed_mode, float *f_Right_Speed_Setpoint, float *f_Left_Speed_Setpoint)
{
	float V, W;
	float tempR, tempL;
	V = (100.0f-fabsf(-f_X_Axis))*(f_Y_Axis/100.0f)+f_Y_Axis;
	W = (100.0f-fabsf(f_Y_Axis))*(-f_X_Axis/100.0f)+(-f_X_Axis);
		
	tempR = ((V+W)/2.0f)*max_rpm_right/100.0f; 
	tempL = ((V-W)/2.0f)*max_rpm_left/100.0f;
	
	if(speed_mode == 'L')
	{
		tempR = tempR/2.0f;
		tempL = tempL/2.0f;
	}
	*f_Right_Speed_Setpoint = tempR;
	*f_Left_Speed_Setpoint = tempL;	
}

void IntToStr_len(int32_t u, uint8_t *byte, uint8_t len)
{
	int32_t a;
	a = u;
	if (a<0)
	{ 
		a = -a; 
		byte[0] = '-';
	}
	else byte[0] = '+';
	
	for(int i = 1; i < len; i++)
	{
		byte[len-i] = a%10 + 0x30;
		a = a/10;
	}
}

float XY_Axes_StrToFloat(uint8_t *byte)
{
	float a = 0;
	for(int i=1; i<6; i++)
	{
		a += (byte[i]-48)*pow(10.0, 5.0-i);
	}
	a /= 100.0f;
	if(byte[0]=='-')
	{
		a = -a;
	}
	return a;
}

float StrToFloat_PID_Para(uint8_t *byte)
{
	float a = 0;
	for(int i=0; i<4; i++)
	{
		a+=(byte[i]-48)*pow(10.0,3.0-i); 
	}
	for(int i=5; i<15; i++)
	{
		a+=(byte[i]-48)/(pow(10.0,i-4.0));
	}
	return a;
}


float StrToFloat_PID_SetPoint(uint8_t *byte)
{
	float a = 0;
	for(int i=1;i<4;i++)
	{
			a+=(byte[i]-48)*pow(10.0,3.0-i);
	}
	a+=(byte[5]-48)/10.0f ;
	
	if(byte[0] == '-')
	{
		a=-a;
	}	
	return a;
	
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



#include "CONTROL.h"

uint8_t stop_str[24]="S M H WH +00000 +00000 E";
bool IsTestPID = false;
float max_rpm_left = 90.0f;
float max_rpm_right = 90.0f;

float time_test = 0.0f;
float f_theta1 = 0.0f;
float f_theta2 = -178.6f;
float f_theta3 = 137.0f;

float enc_dp[WHEEL_MAX_SERVO] = {0, 0};
int32_t enc_p0[WHEEL_MAX_SERVO] = {0, 0}; 
int32_t enc_p1[WHEEL_MAX_SERVO] = {0, 0};

extern uint8_t ui8_dma_rx_buff[DMA_RX_BUFF_SIZE];
extern uint16_t ind;
float x_axis, y_axis;
int32_t i_Arm_Pulse_1, i_Arm_Pulse_2, i_Arm_Pulse_3;
float f_Gripper_Pulse;

float f_left_vel = 0.0f;
float f_right_vel = 0.0f;
float f_setpoint_left_vel = 0.0f;
float f_setpoint_right_vel = 0.0f;
float f_pre1_setpoint_left_vel = 0.0f;
float f_pre1_setpoint_right_vel = 0.0f;
float f_setpoint_left_vel_fil = 0.0f;
float f_setpoint_right_vel_fil = 0.0f;
float f_pre1_setpoint_left_vel_fil = 0.0f;
float f_pre1_setpoint_right_vel_fil = 0.0f;
float f_PID_value_left;
float f_PID_value_right;	
float f_pre1_left_vel = 0.0f;
float f_pre1_right_vel = 0.0f;
float f_left_vel_fil = 0.0f;
float f_right_vel_fil = 0.0f;
float f_pre1_left_vel_fil = 0.0f;
float f_pre1_right_vel_fil = 0.0f;
float Kp_l = 2.3f;
float Ki_l = 2.75f;
float Kd_l = 0.0063f;
float Kp_r = 2.3f;
float Ki_r = 2.75f;
float Kd_r = 0.0063f;
float Pre1_error_R = 0.0f;
float Pre2_error_R = 0.0f;
float Pre_out_R = 0.0f;
float Pre1_error_L = 0.0f;
float Pre2_error_L = 0.0f;
float Pre_out_L = 0.0f;
uint8_t Pre_DIR_L = 0;
uint8_t Pre_DIR_R = 0;

//=========================================================================================

void System_Process(void)
{			
	/*	Received message: 24 bytes
	
	<'S'> <space> <mode: 1 byte> <space> <speed: 1 byte> <space> <affected element: 2 bytes> <space> 
	<X axis value: 6 bytes> <space> <Y axis value: 6 bytes> <space> <'E'> 	
	
	+ 'S': start byte	-> byte 0
	+ mode: "H": control arm to defined home automaticly -> byte 2
					"M": control robot manually
					"C": set PID gains
	+ speed: "H": high speed -> byte 4
					 "L": low speed	
	+ affected element: "WH": wheels	-> byte 6-7
											"J1": base joint
											"J2": joint 2
											"J3": joint 3
											"GR": gripper
	+ X axis value, Y axis value: <sign: "+" or "-"> <3 bytes: integer digits> <2 bytes: decimal digits> -> byte 9-14, byte 16-21
	+ 'E': end byte	-> byte 23
	
	If the current actuator is changed from wheel to an other that is not wheel or none of the actuators are activated, 
	before sending messages of current actuator, remember sending a message of wheel in which x_axis and y_axis values are zero.	
	
	*/	

	if(ui8_dma_rx_buff[0]=='S' && ui8_dma_rx_buff[DMA_RX_BUFF_SIZE-1]=='E')
	{
		switch(ui8_dma_rx_buff[2])
		{
			case 'H':
			{											
				ARM_Servo_Move_To_Defined_Home();								
				break;
			}
			case 'C': 
			{	
				if(ui8_dma_rx_buff[4]=='P' && ui8_dma_rx_buff[5]=='L')
				{
					Kp_l = StrToFloat_PID_Para(&ui8_dma_rx_buff[7]);
				}
				else if(ui8_dma_rx_buff[4]=='I' && ui8_dma_rx_buff[5]=='L')
				{
					Ki_l = StrToFloat_PID_Para(&ui8_dma_rx_buff[7]);
				}
				else if(ui8_dma_rx_buff[4]=='D' && ui8_dma_rx_buff[5]=='L')
				{
					Kd_l = StrToFloat_PID_Para(&ui8_dma_rx_buff[7]);
				}
				else if(ui8_dma_rx_buff[4]=='P' && ui8_dma_rx_buff[5]=='R')
				{
					Kp_r = StrToFloat_PID_Para(&ui8_dma_rx_buff[7]);
				}
				else if(ui8_dma_rx_buff[4]=='I' && ui8_dma_rx_buff[5]=='R')
				{
					Ki_r = StrToFloat_PID_Para(&ui8_dma_rx_buff[7]);
				}
				else if(ui8_dma_rx_buff[4]=='D' && ui8_dma_rx_buff[5]=='R')
				{
					Kd_r = StrToFloat_PID_Para(&ui8_dma_rx_buff[7]);
				}
				else if(ui8_dma_rx_buff[4]=='M' && ui8_dma_rx_buff[5]=='A')
				{
					Cal_Test_Wheel_Speed_Setpoint(&ui8_dma_rx_buff[16], &ui8_dma_rx_buff[9], 'H', &max_rpm_right, &max_rpm_left);
				}
				break;
			}			
			case 'T':
			{
				if(ui8_dma_rx_buff[6]=='W' && ui8_dma_rx_buff[7]=='H')
				{
					if(IsTestPID == true)
					{
						LPF_Wheel_PID_Setpoint();
						Cal_Test_Wheel_Speed_Setpoint(&ui8_dma_rx_buff[16], &ui8_dma_rx_buff[9], ui8_dma_rx_buff[4], &f_setpoint_right_vel, &f_setpoint_left_vel);
						LPF_Vel_Feedback();
						Calculate_PID_Value_Wheel(&f_setpoint_right_vel_fil, &f_setpoint_left_vel_fil, &f_PID_value_right, &f_PID_value_left);
						Wheel_Servo_Write_PWM(f_PID_value_right, f_PID_value_left);
					}									
				}
				else if(ui8_dma_rx_buff[6]=='F' && ui8_dma_rx_buff[7]=='I')
				{	
					Stop_Wheels_Motor();
					memcpy(ui8_dma_rx_buff, stop_str, DMA_RX_BUFF_SIZE);
					IsTestPID = false;
					time_test = 0.0f;
				}
				else if(ui8_dma_rx_buff[6]=='B' && ui8_dma_rx_buff[7]=='E')
				{
					IsTestPID = true;				
				}
				break;
			}
			case 'M':
			{				
				x_axis = XY_Axes_StrToFloat(&ui8_dma_rx_buff[9]);
				y_axis = XY_Axes_StrToFloat(&ui8_dma_rx_buff[16]);				
				if(ui8_dma_rx_buff[6]=='W' && ui8_dma_rx_buff[7]=='H')
				{
					LPF_Wheel_PID_Setpoint();
					Cal_Wheel_Speed_Setpoint(x_axis, y_axis, ui8_dma_rx_buff[4], &f_setpoint_right_vel, &f_setpoint_left_vel);
					LPF_Vel_Feedback();
					Calculate_PID_Value_Wheel(&f_setpoint_right_vel_fil, &f_setpoint_left_vel_fil, &f_PID_value_right, &f_PID_value_left);
					Wheel_Servo_Write_PWM(f_PID_value_right, f_PID_value_left);
				}	
				else if(ui8_dma_rx_buff[6]=='J' && ui8_dma_rx_buff[7]=='1')
				{							
					Cal_Arm_Num_Pulse(x_axis, y_axis, ui8_dma_rx_buff[4], &i_Arm_Pulse_1);
					Arm_Servo_Move(i_Arm_Pulse_1, ARM_SERVO1);
					Stop_Wheels_Motor();
				}	
				else if(ui8_dma_rx_buff[6]=='J' && ui8_dma_rx_buff[7]=='2')
				{							
					Cal_Arm_Num_Pulse(x_axis, y_axis, ui8_dma_rx_buff[4], &i_Arm_Pulse_2);
					Arm_Servo_Move(i_Arm_Pulse_2, ARM_SERVO2);
					Stop_Wheels_Motor();
				}
				else if(ui8_dma_rx_buff[6]=='J' && ui8_dma_rx_buff[7]=='3')
				{
					Cal_Arm_Num_Pulse(x_axis, y_axis, ui8_dma_rx_buff[4], &i_Arm_Pulse_3);
					Arm_Servo_Move(i_Arm_Pulse_3, ARM_SERVO3);
					Stop_Wheels_Motor();
				}		
				else if(ui8_dma_rx_buff[6]=='G' && ui8_dma_rx_buff[7]=='R')
				{
					Cal_Gripper_Pulse_Width(x_axis, y_axis, ui8_dma_rx_buff[4], &f_Gripper_Pulse);
					Gripper_RC_Servo_Write_PWM(f_Gripper_Pulse);
					Stop_Wheels_Motor();						
				}				
				break;
			}		
		}	
	}	
}
//================================================================================================
void Stop_Process(void)
{
	TIM_Cmd(TIM2, DISABLE);
	TIM_SetCounter(TIM2, 0);
	TIM_Cmd(TIM2, ENABLE);
	DMA_Cmd(DMA1_Stream2, DISABLE);
	DMA_Cmd(DMA1_Stream2, ENABLE);
	//Wheel_Servo_Write_PWM(0.0f, 0.0f);
	Arm_Servo_Move(0, ARM_SERVO1);
	Arm_Servo_Move(0, ARM_SERVO2);
	Arm_Servo_Move(0, ARM_SERVO3);
	
	memcpy(ui8_dma_rx_buff, stop_str, DMA_RX_BUFF_SIZE);		
}

bool Is_Connection_Timeout(float time_second)
{
	return (TIM_GetCounter(TIM2) > (uint32_t)(time_second*16800000));	
}



void Stop_Wheels_Motor(void)
{
	LPF_Wheel_PID_Setpoint();
	f_setpoint_right_vel = 0.0f;
	f_setpoint_left_vel = 0.0f;
	LPF_Vel_Feedback();
	Calculate_PID_Value_Wheel(&f_setpoint_right_vel_fil, &f_setpoint_left_vel_fil, &f_PID_value_right, &f_PID_value_left);
	Wheel_Servo_Write_PWM(f_PID_value_right, f_PID_value_left);
}

//=====================================================================================
void Arm_Servo_Write_Pulse(int32_t i_pulse_num, ARM_SERVO_ENUM e_arm_servo)
{
	uint32_t ui_pulse_out;
		

	if(i_pulse_num < 0)
	{
		ui_pulse_out = 0x0080;			
	}
	else
	{
		ui_pulse_out = 0;
	}
	
	if(abs(i_pulse_num) > d_Arm_Max_Pulse_Per_Period)
	{
		ui_pulse_out += d_Arm_Max_Pulse_Per_Period;
	}
	else
	{
		ui_pulse_out += abs(i_pulse_num);
	}
	
	while(GPIO_ReadInputDataBit(GPIOD, GPIO_Pin_13) == Bit_SET);
	FSMC_Write(d_Pulse_Base_ADDR + (e_arm_servo << 1), ui_pulse_out);
	ui_pulse_out = 0;
	
}
void Trigger_P_Write_Pin(void)
{
	uint32_t ui_delay;
	GPIO_SetBits(GPIOD, GPIO_Pin_12);
	ui_delay = 50;
	while(ui_delay--);
	GPIO_ResetBits(GPIOD, GPIO_Pin_12);
}

void Arm_Servo_Move(int32_t i_pulse_num, ARM_SERVO_ENUM e_arm_servo)
{
	int32_t temp;
	temp = i_pulse_num;
	static float temp3 = 0.0f;
	float temp2 = 0.0f;
	
	switch(e_arm_servo)
	{
		case ARM_SERVO1:
		{
			Arm_Servo_Write_Pulse(temp, ARM_SERVO1);
			Arm_Servo_Write_Pulse(0, ARM_SERVO2);
			Arm_Servo_Write_Pulse(0, ARM_SERVO3);
			Trigger_P_Write_Pin();
			
			f_theta1 += (360.0f*d_Driver_Joint_ENC_Line*temp)/(d_Joint_Servo_ENC_Line*d_J1_Gear_Ratio*d_Driver_Joint_PPR);	
			if(f_theta1 >60.0f)
			{
				f_theta1=60.0f;
			}
			else if(f_theta1 <-60.0f)
			{
				f_theta1=-60.0f;
			}
			break;
		}
		case ARM_SERVO2:
		{
			Arm_Servo_Write_Pulse(0, ARM_SERVO1);
			Arm_Servo_Write_Pulse(temp, ARM_SERVO2);
			temp2 = (float)(0.75f*temp) + temp3;
			temp3 = temp2 - (int32_t)(temp2);	
			if((GPIO_ReadInputDataBit(GPIOD, GPIO_Pin_3)== Bit_SET) || (GPIO_ReadInputDataBit(GPIOA, GPIO_Pin_9)== Bit_SET))
			{
				Arm_Servo_Write_Pulse(0, ARM_SERVO3);
			}
			else
			{
				Arm_Servo_Write_Pulse((int32_t)temp2, ARM_SERVO3);
			}			
			Trigger_P_Write_Pin();		
			f_theta2 += (360.0f*d_Driver_Joint_ENC_Line*temp)/(d_Joint_Servo_ENC_Line*d_J2_Gear_Ratio*d_Driver_Joint_PPR);
			if(f_theta2 >32.3f)
			{
				f_theta2=32.3f;
			}
			else if(f_theta2 <-177.6f)
			{
				f_theta2=-177.6f;
			}		
			break;	
		}
		case ARM_SERVO3:
		{
			Arm_Servo_Write_Pulse(0, ARM_SERVO1);
			Arm_Servo_Write_Pulse(0, ARM_SERVO2);
			Arm_Servo_Write_Pulse(temp, ARM_SERVO3);
			Trigger_P_Write_Pin();
			f_theta3 += 1.18f*(360.0f*d_Driver_Joint_ENC_Line*(temp))/(d_Joint_Servo_ENC_Line*d_J3_Gear_Ratio*d_Driver_Joint_PPR);
			if(f_theta3 >137.0f)
			{
				f_theta3=137.0f;
			}
			else if(f_theta3 <-93.0f)
			{
				f_theta3=-93.0f;
			}
			break;
		}
		case ARM_MAX_SERVO:
		{
			break;
		}
	}		
}

void ARM_Servo_Move_To_Defined_Home(void)
{
	DMA_Cmd(DMA1_Stream2, DISABLE);
	Stop_Wheels_Motor();
	if(GPIO_ReadInputDataBit(GPIOD, GPIO_Pin_3) == Bit_SET)
	{
		for(int i=0; i<1667; i++)
		{
			Stop_Wheels_Motor();
			Arm_Servo_Move(5, ARM_SERVO2);
			delay_01ms(10);
		}
	}
	while(GPIO_ReadInputDataBit(GPIOD, GPIO_Pin_2) == Bit_RESET)
	{
		Stop_Wheels_Motor();
		Arm_Servo_Move(5, ARM_SERVO1);
		delay_01ms(10);
	}
	while(GPIO_ReadInputDataBit(GPIOA, GPIO_Pin_8) == Bit_SET)
	{
		Stop_Wheels_Motor();
		Arm_Servo_Move(-5, ARM_SERVO1);
		delay_01ms(10);
	}
	f_theta1 = 0.0f;
	while(GPIO_ReadInputDataBit(GPIOD, GPIO_Pin_3) == Bit_RESET)
	{
		Stop_Wheels_Motor();
		Arm_Servo_Move(-5, ARM_SERVO2);
		delay_01ms(10);
	}
	f_theta2 = -177.6f;
	while(GPIO_ReadInputDataBit(GPIOD, GPIO_Pin_6) == Bit_RESET)
	{
		Stop_Wheels_Motor();
		Arm_Servo_Move(5, ARM_SERVO3);
		delay_01ms(10);
	}
	f_theta3 = 137.0f;
	DMA_Cmd(DMA1_Stream2, ENABLE);
	memcpy(ui8_dma_rx_buff, stop_str, DMA_RX_BUFF_SIZE);
}
void ARM_Servo_Move_To_Defined_Home_Start(void)
{
	for(int i=0; i<3500; i++)
	{
		Stop_Wheels_Motor();
		Arm_Servo_Move(2, ARM_SERVO2);
		delay_01ms(10);
	}
	while(GPIO_ReadInputDataBit(GPIOD, GPIO_Pin_2) == Bit_RESET)
	{
		Stop_Wheels_Motor();
		Arm_Servo_Move(5, ARM_SERVO1);
		delay_01ms(10);
	}
	while(GPIO_ReadInputDataBit(GPIOA, GPIO_Pin_8) == Bit_SET)
	{
		Stop_Wheels_Motor();
		Arm_Servo_Move(-5, ARM_SERVO1);
		delay_01ms(10);
	}
	f_theta1 = 0.0f;
	while(GPIO_ReadInputDataBit(GPIOD, GPIO_Pin_3) == Bit_RESET)
	{
		Stop_Wheels_Motor();
		Arm_Servo_Move(-5, ARM_SERVO2);
		delay_01ms(10);
	}
	f_theta2 = -177.6f;
	while(GPIO_ReadInputDataBit(GPIOD, GPIO_Pin_6) == Bit_RESET)
	{
		Stop_Wheels_Motor();
		Arm_Servo_Move(5, ARM_SERVO3);
		delay_01ms(10);
	}
	f_theta3 = 137.0f;
	memcpy(ui8_dma_rx_buff, stop_str, DMA_RX_BUFF_SIZE);
	Gripper_RC_Servo_Write_PWM(183334);
}

//=====================================================================================
void Gripper_RC_Servo_Write_PWM(float f_Gripper_Duty)
{
	static float f_Gripper_TIM_Pulse = 0;
	f_Gripper_TIM_Pulse += 0.006f*f_Gripper_Duty;
	if(f_Gripper_TIM_Pulse > 1100)
	{
		f_Gripper_TIM_Pulse = 1100;
	}
	else if(f_Gripper_TIM_Pulse < 200)
	{
		f_Gripper_TIM_Pulse = 200;
	}
	
	TIM_SetCompare1(TIM10,(uint32_t)f_Gripper_TIM_Pulse);

	TIM_Cmd(TIM10, ENABLE);
	
}





//=====================================================================================
void Wheel_ENC_Update(void)
{
	for(int index = 0; index < WHEEL_MAX_SERVO; index++)
	{
		enc_p0[index] = (int32_t)FSMC_Read(index);
		enc_dp[index] = (float)((enc_p0[index] - enc_p1[index]));
		if (enc_dp[index] > 32768)
			enc_dp[index] -= 65536;
		else if (enc_dp[index] < -32768)
			enc_dp[index] += 65536;
		enc_p1[index] = enc_p0[index];
	}		
}

float Wheel_Get_Velocity(WHEEL_SERVO_ENUM e_servo)
{
	if(e_servo >= WHEEL_MAX_SERVO)
		return 0;
	float temp;
	switch((int)e_servo)
	{
		case WHEEL_SERVO1:
		{
		//temp = (enc_dp[WHEEL_SERVO1]*2*PI*d_Wheel_Radius)/(d_Wheel_ENC_PPR*d_ENC_Prescale*T_CTRL);		//mps
			temp = (enc_dp[WHEEL_SERVO1]*60.0f)/(d_Wheel_ENC_PPR*d_ENC_Prescale*T_CTRL);
			break;
		}

		
		case WHEEL_SERVO2:
		{
		//temp = (enc_dp[WHEEL_SERVO2]*2*PI*d_Wheel_Radius)/(d_Wheel_ENC_PPR*d_ENC_Prescale*T_CTRL);
			temp = (enc_dp[WHEEL_SERVO2]*60.0f)/(d_Wheel_ENC_PPR*d_ENC_Prescale*T_CTRL);
			break;
		}

	}
	return temp;
}


void Wheel_Servo_Write_PWM(float f_Right_Duty, float f_Left_Duty)
{
	uint32_t ui_Right_TIM_Pulse, ui_Left_TIM_Pulse;	
	if(f_Right_Duty >= 0.0f)
	{
		GPIO_ResetBits(GPIOC, GPIO_Pin_4);			
	}
	else
	{
		GPIO_SetBits(GPIOC, GPIO_Pin_4);				
	}
	if(f_Left_Duty >= 0.0f)
	{
		GPIO_ResetBits(GPIOC, GPIO_Pin_5);			
	}
	else
	{
		GPIO_SetBits(GPIOC, GPIO_Pin_5);				
	}
	ui_Right_TIM_Pulse = (uint32_t)(fabs(f_Right_Duty*d_Max_PWM_Duty_Cycle)*168-1);
	ui_Left_TIM_Pulse = (uint32_t)(fabs(f_Left_Duty*d_Max_PWM_Duty_Cycle)*168-1);	
	TIM_SetCompare1(TIM13, ui_Right_TIM_Pulse);
	TIM_SetCompare1(TIM14, ui_Left_TIM_Pulse);
	TIM_Cmd(TIM13, ENABLE);
	TIM_Cmd(TIM14, ENABLE);
}

void Calculate_PID_Value_Wheel(float *f_Right_SetPoint_vel, float *f_Left_SetPoint_vel, float *f_Right_PID_PWM_Duty, float *f_Left_PID_PWM_Duty)
{	
	float P_part_R = 0.0f;
	float I_part_R = 0.0f;
	float D_part_R = 0.0f;
	float Out_R = 0.0f;
	float Error_R = 0.0f;
	float P_part_L = 0.0f;
	float I_part_L = 0.0f;
	float D_part_L = 0.0f;
	float Out_L = 0.0f;
	float Error_L = 0.0f;
	uint8_t DIR_L = 0;
	uint8_t DIR_R = 0;
	
	
	if(*f_Right_SetPoint_vel >= 0)
	{
		DIR_R = 0;
	}
	else
	{
		DIR_R = 1;
	}
	
	if(*f_Left_SetPoint_vel >= 0)
	{
		DIR_L = 0;
	}
	else
	{
		DIR_L = 1;
	}
	
	if(Pre_DIR_R != DIR_R)
	{
		Pre_out_R = 0.0f;
		Pre1_error_R = 0.0f;
		Pre2_error_R = 0.0f;
		Pre_DIR_R = DIR_R;
	}
	if(Pre_DIR_L != DIR_L)
	{
		Pre_out_L = 0.0f;
		Pre1_error_L = 0.0f;
		Pre2_error_L = 0.0f;
		Pre_DIR_L = DIR_L;
	}
	/* 
		P_part = Kp*(Error - pre_Error);
		I_part = 0.5*Ki*T*(Error + pre_Error);
		D_part = Kd/T*( Error - 2*pre_Error+ pre_pre_Error);
		Out = pre_out + P_part + I_part + D_part ;
		pre_pre_Error = pre_Error
		pre_Error = Error
		pre_Out = Out
	*/
	Error_R = *f_Right_SetPoint_vel - f_right_vel_fil;
	Error_L = *f_Left_SetPoint_vel - f_left_vel_fil;
	P_part_R = Kp_r*(Error_R - Pre1_error_R);
	P_part_L = Kp_l*(Error_L - Pre1_error_L);	
	I_part_R = 0.5f*Ki_r*T_CTRL*(Error_R + Pre1_error_R);
	I_part_L = 0.5f*Ki_l*T_CTRL*(Error_L + Pre1_error_L);	
	D_part_R = Kd_r*(Error_R - 2*Pre1_error_R + Pre2_error_R)/T_CTRL;
	D_part_L = Kd_l*(Error_L - 2*Pre1_error_L + Pre2_error_L)/T_CTRL;	
	Out_R = Pre_out_R + P_part_R + I_part_R + D_part_R;
	Out_L = Pre_out_L + P_part_L + I_part_L + D_part_L;	
	Pre2_error_R = Pre1_error_R;
	Pre2_error_L = Pre1_error_L;	
	Pre1_error_R = Error_R;
	Pre1_error_L = Error_L;	
	Pre_out_R = Out_R;
	Pre_out_L = Out_L;	
	if(Out_R > 100)
	{
		Out_R = 100;
	}
	else if(Out_R < -100)
	{
		Out_R = -100;
	}
	if(Out_L > 100)
	{
		Out_L = 100;
	}
	else if(Out_L < -100)
	{
		Out_L = -100;
	}
	
//	if(Out_R > 25)
//	{
//		Out_R = 25;
//	}
//	else if(Out_R < -25)
//	{
//		Out_R = -25;
//	}
//	if(Out_L > 25)
//	{
//		Out_L = 25;
//	}
//	else if(Out_L < -25)
//	{
//		Out_L = -25;
//	}

		*f_Left_PID_PWM_Duty = Out_L;
		*f_Right_PID_PWM_Duty = Out_R;
}

void LPF_Vel_Feedback(void)
{
	f_right_vel_fil = (1-a_LPF_FB)*f_pre1_right_vel_fil + a_LPF_FB*f_pre1_right_vel;
	f_left_vel_fil = (1-a_LPF_FB)*f_pre1_left_vel_fil + a_LPF_FB*f_pre1_left_vel;	
	f_pre1_right_vel_fil = f_right_vel_fil;
	f_pre1_left_vel_fil = f_left_vel_fil;		
	Wheel_ENC_Update();
	f_right_vel = Wheel_Get_Velocity(WHEEL_SERVO1);
	f_left_vel = Wheel_Get_Velocity(WHEEL_SERVO2);
	f_pre1_right_vel = f_right_vel;
	f_pre1_left_vel = f_left_vel;		
}

void LPF_Wheel_PID_Setpoint(void)
{
	f_setpoint_left_vel_fil = (1-a_LPF_SP)*f_pre1_setpoint_left_vel_fil + a_LPF_SP*f_pre1_setpoint_left_vel;
	f_setpoint_right_vel_fil = (1-a_LPF_SP)*f_pre1_setpoint_right_vel_fil + a_LPF_SP*f_pre1_setpoint_right_vel;
	
	f_pre1_setpoint_left_vel_fil = f_setpoint_left_vel_fil;
	f_pre1_setpoint_right_vel_fil = f_setpoint_right_vel_fil;
	
	f_pre1_setpoint_left_vel = f_setpoint_left_vel;
	f_pre1_setpoint_right_vel = f_setpoint_right_vel;
	
}








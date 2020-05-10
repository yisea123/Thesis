#ifndef _CONTROL_H
#define _CONTROL_H

#include "system_timetick.h"
#include "stdlib.h"
#include "define.h"
#include "math.h"
#include "FSMC.h"
#include "utils.h"
#include "PWM.h"
#include "UART.h"
#include "stdbool.h"
#include "EEPROM_I2C.h"

typedef enum
{
	ARM_SERVO1,
	ARM_SERVO2,
	ARM_SERVO3,
	ARM_MAX_SERVO
}
ARM_SERVO_ENUM;

typedef enum
{
	WHEEL_SERVO1, //right
	WHEEL_SERVO2, //left
	WHEEL_MAX_SERVO
}
WHEEL_SERVO_ENUM;



#define PI	3.141592653589793f
#define d_Arm_Max_Pulse_Per_Period 		20
#define d_Driver_Joint_PPR 						50000.0f
#define d_Driver_Joint_ENC_Line				50000.0f
#define d_J1_Gear_Ratio								112.5f
#define d_J2_Gear_Ratio								200.0f
#define d_J3_Gear_Ratio								150.0f
#define d_Joint_Servo_ENC_Line				1000.0f
#define d_Wheel_ENC_PPR					1800.0f	
#define d_ENC_Prescale 					4.0f
#define d_Max_PWM_Duty_Cycle		1.0f
#define d_max_time_path_planning 5.0f
#define d_max_angle_path_planning 210.0f
#define a_LPF_FB	0.004987520807318f
#define a_LPF_SP	0.004987520807318f


void System_Process(void);
void Arm_Servo_Write_Pulse(int32_t i_pulse_num, ARM_SERVO_ENUM e_arm_servo);
void Arm_Servo_Move(int32_t i_pulse_num, ARM_SERVO_ENUM e_arm_servo);
void ARM_Servo_Move_To_Defined_Home(void);
void ARM_Servo_Move_To_Defined_Home_Start(void);
void Trigger_P_Write_Pin(void);
void Gripper_RC_Servo_Write_PWM(float f_Gripper_Duty);

void Wheel_ENC_Update(void);
float Wheel_Get_Velocity(WHEEL_SERVO_ENUM e_servo);
void Wheel_Servo_Write_PWM(float f_Right_Duty, float f_Left_Duty);

void LPF_Vel_Feedback(void);
void LPF_Wheel_PID_Setpoint(void);
void LPF_Test_Wheel_PID_Setpoint(void);
void Path_Planning_Pulse(ARM_SERVO_ENUM e_servo, float q0, float qf);
float Path_Planning_Cal_Path_Value(uint16_t step, float *a);
void Stop_Process(void);
bool Is_Connection_Timeout(float time_second);
void Stop_Wheels_Motor(void);

#endif


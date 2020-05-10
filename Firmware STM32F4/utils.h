#ifndef _UTILS_H
#define _UTILS_H

#include "system_timetick.h"
#include "math.h"
#include "define.h"
#include "CONTROL.h"


void IntToStr_len(int32_t u, uint8_t *byte, uint8_t len);
void delay_01ms(uint16_t period);
void delay_us(uint16_t period);
void my_delay_us(uint32_t micros);
float XY_Axes_StrToFloat(uint8_t *byte);
float StrToFloat_PID_Para(uint8_t *byte);
float StrToFloat_PID_SetPoint(uint8_t *byte);

void Cal_Wheel_Pulse_Width(float f_X_Axis, float f_Y_Axis, uint8_t speed_mode, float *f_Right_Pulse_Width, float *f_Left_Pulse_Width);
void Cal_Test_Wheel_Speed_Setpoint(uint8_t *ui_Right_SetPoint, uint8_t *ui_Left_SetPoint, uint8_t speed_mode, float *f_Right_Speed_Setpoint, float *f_Left_Speed_Setpoint);
void Cal_Wheel_Speed_Setpoint(float f_X_Axis, float f_Y_Axis, uint8_t speed_mode, float *f_Right_Speed_Setpoint, float *f_Left_Speed_Setpoint);
void Calculate_PID_Value_Wheel(float *f_Right_SP_Speed, float *f_Left_SP_Speed, float *f_Right_PID_Value, float *f_Left_PID_Value);

void Cal_Arm_Num_Pulse(float f_X_Axis, float f_Y_Axis, uint8_t speed_mode, int32_t *i_Arm_Num_Pulse);
void Cal_Gripper_Pulse_Width(float f_X_Axis, float f_Y_Axis, uint8_t speed_mode, float *f_Gripper_Pulse_Width);

#endif


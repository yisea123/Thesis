#ifndef __MOTOR_H
#define __MOTOR_H

typedef enum
{
	JOINT_1,
	JOINT_2,
	JOINT_3,
	MAX_JOINT
}
JOINT_ENUM;

void MOTOR_GPIO_Init(void);
void MOTOR_PWM_Joint_Init(JOINT_ENUM e_joint);
void MOTOR_PWM_Gripper_Init(void);
void MOTOR_PWM_Wheel_Init(void);


#endif

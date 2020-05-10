#ifndef _DEFINE_H
#define _DEFINE_H

//#include "stm32f4xx.h"
//#include "stm32f4xx_conf.h"
//#include "misc.h"
//#include "system_timetick.h"
//#include <stdint.h>
//#include <stdbool.h>
//#include <stdlib.h>
//#include "string.h"
//#include <math.h>
//#include "stdio.h"


#define F_CTRL	1000
#define T_CTRL  0.001f		//1 milisecond

typedef enum
{
	ACT_NONE,
	ACT_JOINT_1,
	ACT_JOINT_2,
	ACT_JOINT_3,
	ACT_GRIPPER,
	ACT_WHEELS	
}
ACTUATOR_ENUM;

//typedef enum
//{
//	SYS_IS_RUNNING,
//	SYS_IS_NOT_RUNNING
//}
//SYS_STATE_ENUM;


#endif


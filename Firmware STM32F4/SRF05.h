#ifndef _SRF05_H
#define _SRF05_H

#include "system_timetick.h"
#include "utils.h"

#define d_Time_per_count_SRF05	5/84000000.0f
#define d_Sound_Speed_SRF05	343.0f

typedef enum
{
	FRONT_SRF05,
	REAR_SRF05,
	GRIPPER_SRF05,
	MAX_SRF05
}
SRF05_SENSOR_ENUM;


void SRF05_Init(void);
void write_SRF05_trigger(SRF05_SENSOR_ENUM e_sensor);

#endif


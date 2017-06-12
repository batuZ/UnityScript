using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_时间 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		//获取启动到当前帧所用的秒数
		float f = Time.time;

		//获取与上一帧的时间间隔，约为 1／60 秒
		//一般用于需要准确控制速度的场合，不受硬件性能影响
		float j = Time.deltaTime;
		//例：让对像每秒旋转120度
		transform.Rotate (Vector3.up, Time.deltaTime * 120);

		// Time.timeScale 缩放或流逝速度,会作用于全局所有与时间有关的组件
		// 一般用于游戏暂停 , 0 为停止，1为正常，2为正常的两倍速度
		Time.timeScale = 1f;
		//将会作用于 动画、物理等组件
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}

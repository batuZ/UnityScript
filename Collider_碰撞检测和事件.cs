using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_碰撞检测和事件 : MonoBehaviour
{

	/*

			Collider 碰撞器 属性

		Is Trigger	:	是否启用碰撞检测或触发检测，默认为false,执行碰撞并触发磁撞事件，
												true为不执行碰撞，但会触发事件


		Material	:	物理材质，设置摩擦力、弹力等,是一种资源，可以像创建普通材质一样创建出来,可以共用
			属性：
				//动摩擦力，当前对象在另一个对象表面滑动时的反作用力
				Dynamic Friction:	
				//静摩擦力，当前对象在另一个对象表面停留时的摩擦力
				Static	Friction:
				//弹力
				Bounciness	:
				//两物体都有物理材质时，作用取值方式
				Friction Combine:	摩擦力
				Bounce Combine:		弹力
					Average:	取平均值
					Minimum:	取最小值
					Multiply:	取乘积
					Maximum:	取最小值
					
	*/

	//碰撞事件：Is Trigger = false
	//碰撞开始时调用一次
	void OnCollisionEnter (Collision other)
	{
	}
	//碰撞进行中持续调用，需要有相对位置变化，静止后不调用
	void OnCollisionStay (Collision other)
	{
		//过滤碰撞对象后执行对应事件，通过对象名或Tag值
		if (string.Equals ("cube", other.gameObject.name)) {
		}
		if (string.Equals ("TagValue", other.gameObject.tag)) {
		}
	}
	//碰撞结束时调用一次
	void OnCollisionExit (Collision other)
	{
	}

	//触发检测：Is Trigger = true
	//进入时触发一次
	void OnTriggerEnter (Collider other)
	{
	}
	//只要在区域内则持续触发
	void OnTriggerStay (Collider other)
	{
	}
	//离开区域触发一次
	void OnTriggerExit (Collider other)
	{
	}
}

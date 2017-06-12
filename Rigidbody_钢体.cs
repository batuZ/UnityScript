using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbody_钢体 : MonoBehaviour
{

	/*
			rigidbody 属性

		Mass : 			质量，影响惯性，两物体碰撞时质量小的受到的影响更大
		Grag : 			空气阻力，只影响下落速度
		Angle Drag : 	角阻力，影响旋转力，在值不为0时，自由旋转会逐渐停止。
		Use Gravity :	是否启用重力属性
		Is Kinematic :	是否启用运动学，与transform冲突，只能使用其中一种。
		Interpolate :	差值，计算运动结果的方法，用来解决运动抖动问题。
			none	:		不计算
			Interpolate : 	内差值，通过上一帧的结果推算当前帧的位置
			Extrapolate	:	外差值，通过预测下一帧的位置反推当前帧结果
		Collision Detection : 碰撞检测模式
			Descrete	:	离散检测，标准的逐帧检测，当物体运动过快时，可能会越过碰撞目标而错过触发。
			Continuous  :	连续检测，防止高速运动物体错过触发的情况。
			Continuous Dynamic : 连续动态检测，当两个物体都是高速运动时，要使用连续动态检测。
		Constraints	:	约束，位移xyz 旋转xyz ,当某项被约束时，不受物理影响。

		
	*/


	// Use this for initialization
	private Rigidbody rb;

	void Start ()
	{
		//获取对象身上的 rigidbody 
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.mass = 1;
		//设置一个物理组件
		Rigidbody newRb = gameObject.AddComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//给物理加一个力
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			
			//加一个过重心向上位移的力
			rb.AddForce (new Vector3 (0, 10, 0));

			//加一个自定义施加点的力
			rb.AddForceAtPosition(
				//力的方向和大小
				new Vector3(0,12,0),
				//力的施加位置
				new Vector3(0.5f,0.5f,0.3f));

			//加一个延Y轴正方向加一个旋转的力,Torque 扭距
			rb.AddTorque (new Vector3 (0, 10, 0));

			//加一个爆炸力
			rb.AddExplosionForce (
				//爆炸力的大小
				1500,
				//爆炸中心的位置
				new Vector3 (1, 2, 3),
				//爆炸半径
				5);
		}
	}
}

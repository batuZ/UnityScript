using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3_向量 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Vector3 vec = new Vector3 ();

		// X, Y, Z
		//vec.x;
		//vec.y;
		//vec.z;

		//获取 vec 的单位向量，改变vec自身的长度为1
		vec.Normalize ();
		//获取 vec 的单位向量，不改变vec本自，而是返回一个新的vector3对象
		Vector3 temp = vec.normalized;
		//获取 vec 的长度
		float lenth = vec.magnitude;


		//类方法:

		//	(0,1,0)
		vec = Vector3.up;
		//	(0,-1,0)
		vec = Vector3.down;
		//	(-1,0,0)
		vec = Vector3.left;
		//	(1,0,0)
		vec = Vector3.right;
		//	(0,0,-1)
		vec = Vector3.forward;
		//	(0,0,1)
		vec = Vector3.back;
		//	(0,0,0)
		vec = Vector3.zero;
		//获取两个向量的夹角角度
		float angle = Vector3.Angle (vec, temp);
		//获取两个点的距离
		float distance = Vector3.Distance (vec, temp);

		//向量点乘，返回一个新的向量
	//	vec = Vector3.Dot (vec, temp);
		//向量叉乘，返回一个新的向量
	//	vec - Vector3.Cross (vec, temp);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}

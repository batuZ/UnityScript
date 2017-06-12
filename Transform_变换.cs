using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_变换 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		// 1、用来修改对象的位置、角度、大小，transform为使用此脚本的对象的transform属性
		Transform thisTrans = transform;

		//全局位置
		Vector3 pos = thisTrans.position;
		//自身位置
		Vector3 localPos = thisTrans.localPosition;

		//缩放
		Vector3 scale = thisTrans.localScale;

		//旋转为四元数，不能直接修改，需要通过方法
		//thisTrans.rotation;
		//thisTrans.localRotation;

		//对象的转角属性，可赋值
		Vector3 angle =	thisTrans.eulerAngles;
		Vector3 localAngle = thisTrans.localEulerAngles;

		//修改对象的位置、角度、大小的方法

		//位移一个次，多次调用可累加
		thisTrans.Translate (Vector3.up);
		//旋转一个次，多次调用可累加
		thisTrans.Rotate (Vector3.up);

		// 2、管理父子关系

		//获取最高级父对象的 Transform
		Transform rootTransform = thisTrans.root;
		//获取父对象的 Transform
		Transform parentTransform = thisTrans.parent;
		//获取子对象的 Transform
		Transform childTransform1 = thisTrans.Find("child");

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}

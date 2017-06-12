using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_射线 : MonoBehaviour
{
	/*
		在场景中点击鼠标，盒子移到点击位置

		1、获取鼠标点击目标点坐标

		2、让盒子移动过去

	*/

	//目标点坐标
	private Vector3 targetCoodr;
	//是否到达位置
	private bool isArevt;
	//移动速度，米/秒
	public float speet;

	void Start ()
	{
		speet = 1;
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			getTargetCoodr ();
		}
		moveTo (targetCoodr);
	}


	/// <summary>
	/// 				1、获取鼠标点击目标点坐标
	/// </summary>
	void getTargetCoodr ()
	{
		//创建一个普通射线，要自定义发出点和发出方向
		Ray ray = new Ray ();

		//由相机发出，经过屏幕上某点的射线,Input.mousePosition鼠标在屏幕上的2D坐标
		Vector3 coodrPM = Input.mousePosition;
		Ray camRay = Camera.main.ScreenPointToRay (coodrPM);

		//创建一个交点信息接收对象
		RaycastHit myHitInfo = new RaycastHit ();

		//发射射线
		bool isHasHit = Physics.Raycast (camRay, out myHitInfo);

		//当有求交对象时
		if (isHasHit) {
			//检测交点目标是不是想要求交的对象，如果是获取hit点的坐标
			if (string.Equals ("Plane_test", myHitInfo.collider.name)) {
				//获取交点坐标
				targetCoodr = myHitInfo.point;
				targetCoodr.y = 0.5f;

				//设置对象没有到达目标坐标
				isArevt = false;
			}
		}
	}

	/// <summary>
	/// 				2、向目标点移动
	/// </summary>
	/// <param name="tar">Tar.</param>
	void moveTo (Vector3 tar)
	{
		if (!isArevt) {
			//获取目标点到当前位置的向量
			Vector3 dic = tar - transform.position;

			//获取 dic 的单位向量，则此向量只表示一个方向
			Vector3 FXiang = dic.normalized;

			//让对象延FXiang方向移动，speet 为移动的速度，Time.deltaTime 为一帧的时间
			// speet * Time.deltaTime 则得到当前帧应该移动的距离,让当前位置延方向增加此距离
			transform.position += FXiang * speet * Time.deltaTime;

			//判断是否已经到达目标位置
			if (Vector3.Distance (transform.position, tar) < 0.1f) {
				isArevt = true;
				//让对象完全移动到目标位置
				transform.position = tar;
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_圆环椭圆环实现代码 : MonoBehaviour
{
	//旋转中心
	private GameObject centerBox;
	//飞行物体
	private GameObject flyBox;
	//半径
	private float r;
	private float rs;
	//每次改变的角度（速度）
	private float angle;
	//状态开关
	private bool stat;

	// Use this for initialization
	void Start ()
	{
		//初始化
		centerBox = GameObject.CreatePrimitive (PrimitiveType.Cube);
		centerBox.transform.position = new Vector3 (10, 5, 0);

		flyBox = GameObject.CreatePrimitive (PrimitiveType.Cube);
		flyBox.transform.localScale = new Vector3 (0.6f, 0.6f, 0.6f);

		r = 10;
		rs = 2;

		angle = 3;

		stat = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnGUI ()
	{
		if (GUI.Button (new Rect (100, 100, 100, 30), "开始！")) {
			stat = true;
		}
		if (GUI.Button (new Rect (230, 100, 100, 30), "停止！")) {
			stat = false;
		}

		if (stat)
			fly ();

	}

	/// <summary>
	/// 环形路径
	/// 椭圆路径思路：用两个同心圆的半径，分别控制两个轴的变化
	/// </summary>
	void fly ()
	{
		//角度转弧度
		float hudu = angle * Mathf.PI / 180;

		//当前角度下flybox的相对位置
		float xChange = r * Mathf.Cos (hudu);
		float zChange = rs * Mathf.Sin (hudu);

		//加上中心目标的坐标值得到flybox的决对坐标
		flyBox.transform.position = new Vector3 (
			centerBox.transform.position.x + xChange,
			centerBox.transform.position.y + 3,
			centerBox.transform.position.z + zChange);
		
		//互相注视
		flyBox.transform.LookAt (centerBox.transform);
		centerBox.transform.LookAt (flyBox.transform);

		//让转角产生变化
		angle++;
	}
}

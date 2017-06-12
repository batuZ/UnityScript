using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_globl_local_的自转 : MonoBehaviour
{
	int stat;
	float xA;
	float yA;
	GameObject box;
	// Use this for initialization
	void Start ()
	{
		box = GameObject.CreatePrimitive (PrimitiveType.Cube);
		box.transform.localScale = new Vector3 (5, 1, 1);
		xA = 0;
		yA = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


	void OnGUI ()
	{
		if (GUI.Button (new Rect (50, 50, 80, 40), "globle")) {
			stat = 1;
		}
		if (GUI.Button (new Rect (150, 50, 80, 40), "local")) {
			stat = 2;
		}
		if (GUI.Button (new Rect (250, 50, 80, 40), "stop")) {
			stat = 0;
		}

		if (stat == 0) {
			box.transform.Rotate (0, 0, 0);
			box.transform.localEulerAngles = new Vector3 (0, 0, 0);
		} else if (stat == 1) {
			//当前轴每次刷新增加一度
			box.transform.Rotate (1, 1, 0);
		} else if (stat == 2) {
			xA++;
			yA++;
			box.transform.localEulerAngles = new Vector3 (xA, yA, 0);
		}
	}
}

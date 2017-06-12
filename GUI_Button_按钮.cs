using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Button_按钮 : MonoBehaviour {

	public Texture2D img;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		//创建一个普通按钮
		GUI.Button (new Rect (50, 100, 150, 20), "按钮1");

		//图像按钮
		GUI.Button	(new Rect (50, 150, 150, 90), img);

		//按钮事件
		if (GUI.Button (new Rect (50, 270, 150, 20), "按钮2")) {
			print ("按钮2被按下！");
			buttonPrass ();
		}
	}

	//按钮事件
	void buttonPrass()
	{
		print ("按钮2件事已触发！");
	}
}

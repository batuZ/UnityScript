using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_windows_弹出窗 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		//初始化一个窗体位置大小
		winRect = new Rect (70, 70, 250, 150);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	int winFlag;
	Rect winRect;

	void OnGUI ()
	{
		if (GUI.Button (new Rect (50, 50, 100, 100), "弹窗！")) 
		{
			winFlag = 1;
		}

		if (winFlag == 1) {
			//			          ID   位置	   回调方法     title
			winRect = GUI.Window (0, winRect, backFunc7, "open a new window");
		}
	}

	void backFunc7 (int winID)
	{
		//设置在此窗体中，点中哪此区域可以进行移动
		GUI.DragWindow (new Rect (0, 0, 250, 20));
	}
}

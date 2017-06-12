using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_scrollView_滚动条 : MonoBehaviour
{
	
	// Use this for initialization
	void Start ()
	{
		vec2 = new Vector2 ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public Texture2D img;
	private Vector2 vec2;

	void OnGUI ()
	{
		vec2 = GUI.BeginScrollView (
			new Rect (50, 50, 150, 150), 	//显示窗口位置及大小
			vec2,							//new Vector2 (12, 7),滚动条横向位置为 12，竖向位置为 7
			new Rect (0, 0, 400, 300));		//后面可在小窗口中显示的界面位置和大小

		GUI.Label (new Rect (20, 20, 384, 576), img);

		GUI.EndScrollView ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Label_文字标签 : MonoBehaviour {
	public Texture2D img1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		//label 不能引发事件
		//					  x , y , 长 ，宽      内容
		GUI.Label (new Rect (50, 50, 150, 20), "文字标签");
		GUI.Label (new Rect (240, 50, 150, 90), img1);
	}
}

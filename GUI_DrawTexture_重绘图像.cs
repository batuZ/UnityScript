using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_DrawTexture_重绘图像 : MonoBehaviour {

	public Texture2D img;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	int length = 150;
	void OnGUI(){
		//按比例变化
		GUI.Label (new Rect (30, 60, length, 180), img);
		//按设置，不等比变化，用来做血条
		GUI.DrawTexture (new Rect (30, 200, length, 180), img);

		if (GUI.Button (new Rect (20, 20, 40, 20), "+")) {
			if (length < 300) {
				length += 10;
			}
		}
		if (GUI.Button (new Rect (70, 20, 40, 20), "-")) {
			if (length > 0) {
				length -= 10;
			}
		}
	
	}
}

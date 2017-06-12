using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_TextField_文本输入 : MonoBehaviour {

	public string heheName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	string inputStr = "输入文字...";
	string pwf = "";
	void OnGUI(){
		//用户名
		inputStr = GUI.TextField (new Rect (50, 50, 100, 20), inputStr);

		//密码
		pwf = GUI.PasswordField (new Rect (160, 50, 100, 20), pwf, '*');
	}

	public void myFunc(string fu){


	}
}

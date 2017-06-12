using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Toggle_点选框 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		sex = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	bool sex;
	void OnGUI(){
		//单选
		sex = GUI.Toggle (new Rect (200, 50, 80, 20), sex, "男");
		sex = GUI.Toggle (new Rect (300, 50, 80, 20), !sex, "女");
	}
}

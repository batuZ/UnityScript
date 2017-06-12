using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_控制物体 : MonoBehaviour
{

	private GameObject box;
	private GameObject plan;
	private float speed = 0.1f;
	// Use this for initialization
	void Start ()
	{
		box = GameObject.Find ("Cube_test");
		plan = GameObject.Find ("Plane_test");
	}
	
	// 键盘
	void Update ()
	{
		if (Input.GetKey (KeyCode.A)) {
			Vector3 X = box.transform.position;
			X.x -= speed;
			box.transform.position = X;
		}
		if (Input.GetKey (KeyCode.D)) {
			Vector3 X = box.transform.position;
			X.x += speed;
			box.transform.position = X;
		}
		if (Input.GetKey (KeyCode.W)) {
			Vector3 Z = box.transform.position;
			Z.z += speed;
			box.transform.position = Z;
		}
		if (Input.GetKey (KeyCode.S)) {
			Vector3 Z = box.transform.position;
			Z.z -= speed;
			box.transform.position = Z;
		}
		if (Input.GetKey (KeyCode.Space)) {
			Vector3 Y = box.transform.position;
			Y.y += speed;
			box.transform.position = Y;
		}
	}

	Vector3 mosVec = new Vector3 ();
	//鼠标
	void LateUpdate ()
	{
		//平移
		if (Input.GetMouseButtonDown (0)) {
			mosVec = Input.mousePosition;
		}
		if (Input.GetMouseButton (0)) {
			Vector3 temoMous = Input.mousePosition - mosVec;
			mosVec = Input.mousePosition;
			Vector3 camTrans = new Vector3 (
				                   this.transform.position.x - temoMous.x * 0.02f,
				                   this.transform.position.y,
				                   this.transform.position.z - temoMous.y * 0.02f);
			this.transform.position = camTrans;
		}
		//视角
		if (Input.GetMouseButtonDown (1)) {
			mosVec = Input.mousePosition;
		}
		if (Input.GetMouseButton (1)) {
			Vector3 temoMous = Input.mousePosition - mosVec;
			mosVec = Input.mousePosition;
			Vector3 camTrans = new Vector3 (
				                   this.transform.localEulerAngles.x + temoMous.y * 0.1f,
				                   this.transform.localEulerAngles.y + temoMous.x * 0.1f,
				                   this.transform.localEulerAngles.z);
			this.transform.localEulerAngles = camTrans;
		}
	}
}

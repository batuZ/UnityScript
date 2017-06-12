using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_基本模型 : MonoBehaviour
{

	List<GameObject> objList;
	int s;

	// Use this for initialization
	void Start ()
	{
		s = 0;
		objList = new List<GameObject> ();

		//GameObject 控制

		// 1、获取此脚本所在对象
		GameObject thisObj = gameObject;

		// 2、对象名
		thisObj.name = "testName";

		// 3、对象Tag
		thisObj.tag = "cubeList";

		// 4、设置激活状态
		thisObj.SetActive (true);

		// 5、获取对象身上某组件
		aboutCS_Script temp = thisObj.GetComponent<aboutCS_Script> ();

		// 6、给对象增加组件，如灯或重力组件
		Light l = thisObj.AddComponent<Light> ();
		Rigidbody r = thisObj.AddComponent<Rigidbody> ();

		// 7、通过Tag值找到对象s
		GameObject obj0 = GameObject.FindWithTag ("Tag");
		GameObject obj1 = GameObject.FindGameObjectWithTag ("tag");
		GameObject[] objs = GameObject.FindGameObjectsWithTag ("tag");

		// 8、通过name找到对象
		GameObject obj3 = GameObject.Find ("objectName");

		// 9、消毁对象(对象，延迟秒）
		GameObject.Destroy(obj0,1.5f);

	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	/// 技术点：
	/// 1、创建一个对象
	/// 2、修改对象属性
	/// 3、删除对象
	/// 4、copy出独立全新的对象
	/// 5、将对象设置为引用（profab）物体，并copy出引用副本
	/// 6、让对象注视一个 transform

	void OnGUI ()
	{
		if (GUI.Button (new Rect (50, 50, 150, 20), "创建盒子")) {
			createBox (s += 2);
		}
		if (GUI.Button (new Rect (250, 50, 150, 20), "删掉盒子")) {
			deleteBox ();
		}
		if (GUI.Button (new Rect (450, 50, 100, 20), "变大")) {
			bigger ();
		}
		if (GUI.Button (new Rect (560, 50, 100, 20), "变小")) {
			smaller ();
		}
	}

	void createBox (int f)
	{
		GameObject box = GameObject.CreatePrimitive (PrimitiveType.Cube);
		box.transform.position = new Vector3 (f, 0, 10);
		box.name = "box" + f;
		objList.Add (box);

		//如果原对象是普通模型，则会 copy一个独立的目标对象
		//如果原对象是profab，则会 copy 一个引用对象，引用对象几乎不占用资源
		GameObject cpBox = GameObject.Instantiate (box);
		cpBox.transform.position = new Vector3 (
			cpBox.transform.position.x, 
			cpBox.transform.position.y + 1.5f, 
			cpBox.transform.position.z);

		//让对象注视一个 transform
		GameObject lt = GameObject.Find ("Directional Light");
		cpBox.transform.LookAt (lt.transform);
	}

	void deleteBox ()
	{
		GameObject temp = GameObject.Find ("box" + s);
		Destroy (temp);
		s -= 2;
	}

	void bigger ()
	{
		for (int k = 0; k < objList.Count; k++) {
			GameObject temp = objList [k];
			Vector3 tempTrans = temp.transform.localScale;
			tempTrans.Set (tempTrans.x + 0.2f, tempTrans.y + 0.2f, tempTrans.z + 0.2f);
			temp.transform.localScale = tempTrans;
		}
	}

	void smaller ()
	{
		for (int k = 0; k < objList.Count; k++) {
			GameObject temp = objList [k];
			Vector3 tempTrans = temp.transform.localScale;
			tempTrans.Set (tempTrans.x - 0.2f, tempTrans.y - 0.2f, tempTrans.z - 0.2f);
			temp.transform.localScale = tempTrans;
		}
	}
}

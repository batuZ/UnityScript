using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_动态创建预设体 : MonoBehaviour
{

	//获取预设体
	public GameObject objPrefab;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.P)) {
			//原地复制一个副本
			GameObject newOne =	(GameObject)Instantiate (objPrefab);

			//重载方法，输入transform参数
			float px = Random.Range (-10f, 10f);
			float py = Random.Range (-10f, 10f);
			Vector3 pos = new Vector3 (px, 1f, py);
			Quaternion rot = Quaternion.AngleAxis (Random.Range (0f, 360f), Vector3.up);
			Instantiate (objPrefab, pos, rot);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 鼠标事件 : MonoBehaviour
{
	//只有鼠标在对象身上时才会有效！！

	//在对象体上按下鼠标时触发一次
	void OnMouseDown ()
	{
	}
	//在对象体上按下鼠标，只要不抬起则连续触发
	void OnMouseDrag ()
	{
	}
	//在对象体上按下鼠标后，再抬起时触发一次
	void OnMouseUp ()
	{
	}
	//在对象体上按下鼠标后，在对象身上抬起时触发一次，离开对象抬起不触发
	void OnMouseUpAsButton ()
	{
	}
	//鼠标滑入对象时触发一次
	void OnMouseEnter ()
	{
	}
	//鼠标只要在对象身上就连续触发
	void OnMouseOver ()
	{
	}
	//鼠标滑出对象时触发一次
	void OnMouseExit ()
	{
	}
}

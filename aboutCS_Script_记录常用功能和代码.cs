using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
				MonoDevelop_常 用

整理代码	： Edit -> Format -> FormatDocment

在 MonoBehaviour 子类中打印消息可以用 print 或 Debug.Log,
非MonoBehaviour字类中只能用 Debug.Log打印

编译： command + B 


				UnityEditor_常 用

快捷键 ： 

	把camera移动到场景视图中的观察位置 ：选中 camera ,command + shift + f 
	模型对象的操作工具切换 ： Q,W,E,R,T
	


*/









//每个脚本都要加载到一个对象上才能执行
public class aboutCS_Script : MonoBehaviour
{
	// 脚本被加载时运行，即使脚本并没有被激活，只运行一次
	// 可当作构造方法使用，【初使化publice成员变量】,供其它脚本调用
	void OnAwake ()
	{
	}
	//激活脚本时，在 start以前运行一次
	//一般用来【重置】一些特定属重
	void OnEnable ()
	{
	}
	// 在第一次调用 upDate 之前调用一次 strat
	// 在脚本运行过程中只调用一次，停止再激活时不会调用
	// 可当作构造方法使用，【初使化私有成员变量】
	void Start ()
	{
		//使用此脚本的游戏对象的名子
		string objectName =	gameObject.name;

		//使用此脚本的游戏对象的transform
		Transform objectTrans =	transform;

		//使用此脚本的游戏对象所使用的其它脚本对象
		GUI_TextField_文本输入 ee = GetComponent<GUI_TextField_文本输入> ();
		ee.heheName = "test";
		ee.myFunc ("test");

	}
	
	// 状态机：界面每秒刷新60次，每次刷新都可以定义动作，让界面响应
	void Update ()
	{
	}
	//updata完成后调用
	//一般用来处理updata运行结果，进行更新
	void LateUpdate ()
	{
	}
	//取消激活状态后调用，对应OnEnable
	void OnDisable ()
	{
	}
	//脚本被消毁时调用，只调用一次
	//一般用于怪死亡掉装备时使用
	void OnDestroy ()
	{
	}
	//Unity内置GUI，每秒刷新120次，在移动端效率较低
	//一般Debug时用
	void OnGUI ()
	{
	}
	//以固定频率刷新，不受硬件影响
	//一般处理需要还原物理特性的动作时使用
	void FixedUpdate ()
	{
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeManager : MonoBehaviour 
{
	public GameObject LapTimeManagers;
	public GameObject MinuteTimeManager;
	public GameObject SecondTimeManager;
	public GameObject MilliSecondTimeManager;
	public static int minute = 0;
	public static int second = 0;
	public static float millisecond=0.0f;
	public void Start()
	{
		minute = 0;
		second = 0;
		millisecond = 0;
	}
	public void Update()
	{
		millisecond = millisecond+Time.deltaTime*1000;
		MilliSecondTimeManager.GetComponent<Text> ().text = millisecond.ToString();
		SecondTimeManager.GetComponent<Text> ().text = second.ToString ()+":";
		MinuteTimeManager.GetComponent<Text> ().text = minute.ToString ()+":";
		if (millisecond>999) 
		{
			second = second + 1;
			millisecond = 0;
		}
		if (second >59) 
		{
			second = 0;
			minute = minute + 1;
		}
		}
}

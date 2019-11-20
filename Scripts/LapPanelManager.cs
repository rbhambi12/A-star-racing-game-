using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapPanelManager : MonoBehaviour 
{
	public GameObject LapTime;
	public GameObject MinuteTime;
	public GameObject SecondTime;
	public GameObject MilliSecondTime;
	public GameObject LapNumber;
	public float minute=(float)00;
	public float second=(float)00;
	public float millisecond=(float)00;
	public static int numberoflaps;
	public int internalnumberoflaps;
	public int totalnumberoflaps;
	public void Start()
	{
		numberoflaps = 0;
		totalnumberoflaps = 3;
		LapTime.GetComponent<Text> ().text = "Lap Time";
		MinuteTime.GetComponent<Text> ().text = minute.ToString()+":";
		SecondTime.GetComponent<Text> ().text = second.ToString () + ":";
		MilliSecondTime.GetComponent<Text> ().text = millisecond.ToString ();
		LapNumber.GetComponent<Text> ().text = "Number of Laps:"+numberoflaps+"/"+totalnumberoflaps;
	}
	public void Update()
	{
		MinuteTime.GetComponent<Text> ().text = minute.ToString()+":";
		SecondTime.GetComponent<Text> ().text = second.ToString () + ":";
		MilliSecondTime.GetComponent<Text> ().text = millisecond.ToString ();
		LapNumber.GetComponent<Text> ().text = "Number of Laps:"+numberoflaps+"/"+totalnumberoflaps;

	}

}

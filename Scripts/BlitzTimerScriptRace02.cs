using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
public class BlitzTimerScriptRace02 : MonoBehaviour 
{
	public GameObject RemainingTimeMin;
	public GameObject RemainingTimeSec;
	public GameObject RemainingTimeMillisec;
	public static int minutes;
	public static float millisec;
	public static int seconds;
	public GameObject Car;
	public GameObject PausePanel;
	public GameObject RaceFinishTrigger;
	public static bool PlayerLostRace;
	public void Start()
	{
		minutes = 1;
		seconds = 5;
		millisec = 999;
		RemainingTimeMin.GetComponent<Text> ().text = "1";
		RemainingTimeSec.GetComponent<Text> ().text = "15";
		RemainingTimeMillisec.GetComponent<Text> ().text = "999";
		PlayerLostRace = false;

	}
	public void Update()
	{
		RemainingTimeMillisec.GetComponent<Text> ().text = millisec.ToString ();
		RemainingTimeSec.GetComponent<Text> ().text = seconds.ToString () + ":";
		RemainingTimeMin.GetComponent<Text> ().text = minutes.ToString ()+":";
		millisec = millisec - Time.deltaTime * 1000;
		if (millisec<=0) 
		{
				millisec =999;
				if (seconds == 0) 
			{
					seconds = 59;
					minutes = minutes - 1;
				} else {
					seconds = seconds - 1;
			}
			if (minutes == -1 && seconds ==59) 
			{
				minutes = 0;
				seconds = 0;
				millisec = 0;
				Car.GetComponent<CarAIControlFinishRace> ().enabled = true;
				Car.GetComponent<CarUserControl> ().enabled = false;
				RemainingTimeMin.GetComponent<Text> ().color = Color.red;
				RemainingTimeMin.GetComponent<Text> ().text = "Time's Up! You Lost!";
				RemainingTimeSec.GetComponent<Text> ().text = "";
				RemainingTimeMillisec.GetComponent<Text> ().text = "";
				RaceFinishTrigger.SetActive (false);
				PausePanel.SetActive (true);
				PlayerLostRace = true;
				this.gameObject.SetActive (false);
			}

		}

	}
}

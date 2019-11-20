using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
public class BlitzRaceFinishScriptRace02 : MonoBehaviour 
{
	public GameObject BlitzTimerScript;
	public GameObject RaceFinishText;
	public GameObject RaceFinishCamera;
	public GameObject FollowCamera;
	public GameObject Car;
	public static bool PlayerFinishedRace;
	public GameObject WrongWayDetection;
	public GameObject Progress;
	public GameObject WrongWay;
	public void OnTriggerEnter(Collider other)
	{
		this.gameObject.GetComponent<BoxCollider> ().enabled = false;
		PlayerFinishedRace = true;
		WrongWayDetection.SetActive (false);
		WrongWay.SetActive (false);
		Car.GetComponent<CarAIControlFinishRace> ().enabled = true;
		Car.GetComponent<CarUserControl> ().enabled = true;
		BlitzTimerScript.SetActive (false);
		RaceFinishText.GetComponent<Text> ().color = Color.green;
		RaceFinishText.GetComponent<Text> ().text = "You Won!";
		RaceFinishText.SetActive (true);
		RaceFinishCamera.SetActive (true);
		FollowCamera.SetActive (false);
		Progress.SetActive (false);
		this.gameObject.GetComponent<BoxCollider> ().enabled = true;
	}
}

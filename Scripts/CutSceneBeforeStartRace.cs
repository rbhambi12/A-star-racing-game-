using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneBeforeStartRace : MonoBehaviour 
{
	public GameObject StartCamera;
	public GameObject FollowCamera;
	public GameObject CutSceneCamera;
	public GameObject CountDown;
	public GameObject Progress;
	public GameObject Trigger1;
	public GameObject Trigger2;
	public GameObject Trigger3;
	public GameObject Trigger4;
	public GameObject Trigger5;

	public void Start()
	{
		StartCoroutine (WaitingForCars ());
	}
	public IEnumerator WaitingForCars()
	{
		yield return new WaitForSeconds (9.0f);
		CutSceneCamera.SetActive (true);
		StartCamera.SetActive (false);
		yield return new WaitForSeconds (3.7f);
		FollowCamera.SetActive (true);
		CutSceneCamera.SetActive (false);
		Trigger1.SetActive (false);
		Trigger2.SetActive (false);
		Trigger3.SetActive (false);
		Trigger4.SetActive (false);
		Trigger5.SetActive (false);
		CountDown.SetActive (true);
		Progress.SetActive (true);

	}
}

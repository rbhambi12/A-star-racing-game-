using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class MainMenuCar3Tracker : MonoBehaviour 
{
	public GameObject Car3;
	public void OnTriggerEnter()
	{
		if (MainMenuCarRaceAnimation.car3track == 4) 
		{
			this.gameObject.GetComponent<BoxCollider> ().enabled = false;
			Car3.SetActive (false);
			Car3.GetComponent<CarAIControl> ().enabled = false;
			Car3.GetComponent<CarController> ().enabled = false;
			Car3.GetComponent<CarAudio> ().enabled = false;
			Car3.SetActive (true);
			this.gameObject.GetComponent<BoxCollider> ().enabled = true;
		} 
		else
		{
			this.gameObject.GetComponent<BoxCollider> ().enabled = false;
			MainMenuCarRaceAnimation.car3track += 1;
			StartCoroutine (Enable ());
		}
	}	
	public IEnumerator Enable()
	{
		yield return new WaitForSeconds (0.2f);
		this.gameObject.GetComponent<BoxCollider> ().enabled = true;
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class MainMenuCar1Tracker : MonoBehaviour 
{
	public GameObject Car1;
	public void OnTriggerEnter()
	{
		if (MainMenuCarRaceAnimation.car1track == 4) 
		{
			this.gameObject.GetComponent<BoxCollider> ().enabled = false;
			Car1.SetActive (false);
			Car1.GetComponent<CarAIControl> ().enabled = false;
			Car1.GetComponent<CarController> ().enabled = false;
			Car1.GetComponent<CarAudio> ().enabled = false;
			Car1.SetActive (true);
			this.gameObject.GetComponent<BoxCollider> ().enabled = true;

		} 
		else
		{			this.gameObject.GetComponent<BoxCollider> ().enabled = false;
			MainMenuCarRaceAnimation.car1track += 1;
			StartCoroutine (Enable ());

		}
	}	
	public IEnumerator Enable()
	{
		yield return new WaitForSeconds (0.2f);
		this.gameObject.GetComponent<BoxCollider> ().enabled = true;
	}
}

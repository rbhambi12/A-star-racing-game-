using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class MainMenuCar2Tracker : MonoBehaviour {
	public GameObject Car2;
	public void OnTriggerEnter()
	{	
		if (MainMenuCarRaceAnimation.car2track == 4) 
		{
			this.gameObject.GetComponent<BoxCollider> ().enabled = false;
			Car2.SetActive (false);
			Car2.GetComponent<CarAIControl> ().enabled = false;
			Car2.GetComponent<CarController> ().enabled = false;
			Car2.GetComponent<CarAudio> ().enabled = false;
			Car2.SetActive (true);
			this.gameObject.GetComponent<BoxCollider> ().enabled = true;
		} 
		else
		{			this.gameObject.GetComponent<BoxCollider> ().enabled = false;
			MainMenuCarRaceAnimation.car2track += 1;
			StartCoroutine (Enable ());
		}
	}	
	public IEnumerator Enable()
	{
		yield return new WaitForSeconds (0.2f);
		this.gameObject.GetComponent<BoxCollider> ().enabled = true;
	}
}

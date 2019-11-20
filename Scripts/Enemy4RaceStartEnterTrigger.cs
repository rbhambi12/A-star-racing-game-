using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class Enemy4RaceStartEnterTrigger: MonoBehaviour 
{
	public GameObject Car;
	public void OnTriggerEnter()
	{
		this.gameObject.GetComponent<BoxCollider>().enabled=false;
		Car.SetActive (false);
		Car.GetComponent<CarUserControl> ().enabled = true;
		Car.GetComponent<CarAIControlStartRace> ().enabled = false;
		Car.GetComponent<CarController> ().enabled = false;
		Car.SetActive (true);
		Car.GetComponent<CarUserControl> ().enabled = false;
		this.gameObject.GetComponent<BoxCollider>().enabled=true;
	}
}

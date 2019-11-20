using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DistanceFromOtherCars : MonoBehaviour 
{
	public GameObject Car1;
	public GameObject Car2;
	public GameObject Car3;
	public GameObject Car4;
	public GameObject Car5;
	public GameObject Car1Distance;
	public GameObject Car2Distance;
	public GameObject Car3Distance;
	public GameObject Car4Distance;
	public float distance;
	public void Update()
	{
		distance = Vector3.Distance (Car1.transform.position, Car2.transform.position);	
		Car1Distance.GetComponent<Text> ().text = distance.ToString ("f1")+" m";
		distance = Vector3.Distance (Car1.transform.position, Car3.transform.position);	
		Car2Distance.GetComponent<Text> ().text = distance.ToString ("f1")+" m";
		distance = Vector3.Distance (Car1.transform.position, Car4.transform.position);	
		Car3Distance.GetComponent<Text> ().text = distance.ToString ("f1")+" m";
		distance = Vector3.Distance (Car1.transform.position, Car5.transform.position);	
		Car4Distance.GetComponent<Text> ().text = distance.ToString ("f1")+" m";
	}
}

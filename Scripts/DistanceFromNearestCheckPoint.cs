using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DistanceFromNearestCheckPoint : MonoBehaviour 
{
	public GameObject Distance;
	public GameObject Car;
	public float distance;
	public GameObject PointerDirector;
	public void Update()
	{
		distance = Vector3.Distance (Car.transform.position, PointerDirector.transform.position);
		Distance.GetComponent<Text> ().text = "Distance from nearest Checkpoint:"+distance.ToString()+" m";
	}
}

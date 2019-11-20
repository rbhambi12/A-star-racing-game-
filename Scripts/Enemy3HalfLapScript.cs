using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3HalfLapScript : MonoBehaviour 
{
	public GameObject HalfLapTrig;
	public GameObject LapCompleteTrig;
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "EnemyCar3") 
		{
			LapCompleteTrig.SetActive (true);
			HalfLapTrig.SetActive (false);
		}
	
	}	
}

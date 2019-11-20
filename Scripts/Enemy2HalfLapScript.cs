using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2HalfLapScript : MonoBehaviour 
{
	public GameObject HalfLapTrig;
	public GameObject LapCompleteTrig;
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "EnemyCar2") 
		{
			LapCompleteTrig.SetActive (true);
			HalfLapTrig.SetActive (false);
		}
	
	}	
}

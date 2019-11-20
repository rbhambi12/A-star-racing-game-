using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHalfLapScript : MonoBehaviour 
{
	public GameObject HalfLapTrig;
	public GameObject LapCompleteTrig;
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "AICar") 
		{
			LapCompleteTrig.SetActive (true);
			HalfLapTrig.SetActive (false);
		}
	
	}	
}

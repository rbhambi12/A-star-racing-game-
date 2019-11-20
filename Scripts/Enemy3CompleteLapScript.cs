
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3CompleteLapScript : MonoBehaviour 
{
	public GameObject HalfLapScripts;
	public GameObject LapCompleteScript;
	public GameObject RaceFinishScript;
	public int enemy3nooflaps=0;
	public void OnTriggerEnter(Collider other)
	{ 	if (other.gameObject.tag == "EnemyCar3") {
		HalfLapScripts.SetActive (true);
			enemy3nooflaps += 1;
			if (enemy3nooflaps == 3) 
		{
			RaceFinishScript.SetActive (true);
		} 
		LapCompleteScript.SetActive (false);
	}
}
}

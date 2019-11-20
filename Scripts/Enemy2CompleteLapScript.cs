using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2CompleteLapScript : MonoBehaviour 
{
	public GameObject HalfLapScripts;
	public GameObject LapCompleteScript;
	public GameObject RaceFinishScript;
	public int enemy2nooflaps=0;
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "EnemyCar2") {
			HalfLapScripts.SetActive (true);
			enemy2nooflaps += 1;
			if (enemy2nooflaps == 3) {
				RaceFinishScript.SetActive (true);
			} 
			LapCompleteScript.SetActive (false);
		}
	}
}

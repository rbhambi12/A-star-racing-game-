using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4CompleteLapScript : MonoBehaviour 
{
	public GameObject HalfLapScripts;
	public GameObject LapCompleteScript;
	public GameObject RaceFinishScript;
	public int enemy4nooflaps=0;
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "EnemyCar4") {
		HalfLapScripts.SetActive (true);
			enemy4nooflaps += 1;
			if (enemy4nooflaps == 3) 
		{
			RaceFinishScript.SetActive (true);
		}
		LapCompleteScript.SetActive (false);
	}
}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckPointScriptBlitzRace02 : MonoBehaviour 
{
	public GameObject CheckPointText;
	public static int noofcheckpoints=0;
	public int internalcheck;
	public float distance;
	public GameObject WrongWay;
	public void Update()
	{
		internalcheck = noofcheckpoints;
		CheckPointText.GetComponent<Text> ().text = noofcheckpoints.ToString ();
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			noofcheckpoints += 1;
		}
	}
}

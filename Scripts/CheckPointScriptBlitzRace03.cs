using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckPointScriptBlitzRace03 : MonoBehaviour 
{
	public GameObject CheckPointText;
	public static int noofcheckpoints=0;
	public int internalcheck;
	public float distance;
	public GameObject WrongWay;
	public void Update()
	{
		internalcheck = noofcheckpoints;
		if(noofcheckpoints<10)
		CheckPointText.GetComponent<Text> ().text = "0"+noofcheckpoints.ToString ();
		else
		CheckPointText.GetComponent<Text> ().text =noofcheckpoints.ToString ();
				
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			noofcheckpoints += 1;
		}
	}
}

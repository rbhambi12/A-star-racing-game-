using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckPointScript : MonoBehaviour 
{
	public GameObject CheckPointText;
	public static int noofcheckpoints=0;
	public static int enemynoofcheckpoints=0;
	public static int enemy2noofcheckpoints = 0;
	public static int enemy3noofcheckpoints = 0;
	public static int enemy4noofcheckpoints=0;
	public int internalcheck;
	public float distance;

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
		if (other.gameObject.tag =="AICar")
		{
			enemynoofcheckpoints += 1;
		}
		if (other.gameObject.tag == "EnemyCar2") 
		{
			enemy2noofcheckpoints += 1;
		}
		if (other.gameObject.tag == "EnemyCar3") 
		{
			enemy3noofcheckpoints += 1;
		}
		if (other.gameObject.tag == "EnemyCar4") 
		{
			enemy4noofcheckpoints += 1;
		}

	}
}

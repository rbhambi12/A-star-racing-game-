using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlitzProgressRace02 : MonoBehaviour 
{
	public GameObject ProgressText;	
	public GameObject ProgressObject;
	public float distance;
	public GameObject Car;
	public float cardistance;
	public float progressvar;
	public int x=0;
	public void Start()
	{
		ProgressText.GetComponent<Text> ().text = "0%";
		ProgressObject.GetComponent<Text> ().text = "Progress:";
	}

	public void Update()
	{
		cardistance = BlitzSpeedOfCar.distance;
		progressvar = (cardistance / 2500)*100;
		if (progressvar > 100) 
		{
			progressvar = 100.0f;
		}
		ProgressText.GetComponent<Text> ().text = progressvar.ToString("f0")+"%";
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCarRaceAnimation : MonoBehaviour 
{
	public GameObject Tracker1;
	public GameObject Tracker2;
	public GameObject Tracker3;
	public GameObject Camera1;
	public GameObject Camera2;
	public GameObject Camera3;
	public GameObject WayPoint11;
	public GameObject WayPoint12;
	public GameObject WayPoint13;
	public GameObject WayPoint14;
	public GameObject WayPoint15;
	public GameObject WayPoint21;
	public GameObject WayPoint22;
	public GameObject WayPoint23;
	public GameObject WayPoint24;
	public GameObject WayPoint25;
	public GameObject WayPoint31;
	public GameObject WayPoint32;
	public GameObject WayPoint33;
	public GameObject WayPoint34;
	public GameObject WayPoint35;
	public static int car1track=0;
	public int car1inttrack;
	public static int car2track=0;
	public int car2inttrack;
	public int car3inttrack;
	public static int car3track=0;
	public void Start ()
	{
		StartCoroutine (MainMenuAnim ());
	}

	public void Update()
	{
		car1inttrack = car1track;
		car2inttrack = car2track;
		car3inttrack = car3track;
		if (car1track == 0) 
		{
			Tracker1.transform.position = WayPoint11.transform.position;
		}
		if (car1track == 1) 
		{
			Tracker1.transform.position = WayPoint12.transform.position;
		}
		if (car1track == 2) 
		{
			Tracker1.transform.position = WayPoint13.transform.position;
		}
		if (car1track == 3) 
		{
			Tracker1.transform.position = WayPoint14.transform.position;
		}
		if (car1track == 4) 
		{
			Tracker1.transform.position = WayPoint15.transform.position;
		}
		if (car2track == 0) 
		{
			Tracker2.transform.position = WayPoint21.transform.position;
		}
		if (car2track == 1) 
		{
			Tracker2.transform.position = WayPoint22.transform.position;
		}
		if (car2track == 2) 
		{
			Tracker2.transform.position = WayPoint23.transform.position;
		}
		if (car2track == 3) 
		{
			Tracker2.transform.position = WayPoint24.transform.position;
		}
		if (car2track == 4) 
		{
			Tracker2.transform.position = WayPoint25.transform.position;
		}
		if (car3track == 0) 
		{
			Tracker3.transform.position = WayPoint31.transform.position;
		}

		if (car3track == 1) 
		{
			Tracker3.transform.position = WayPoint32.transform.position;
		}
		if (car3track == 2) 
		{
			Tracker3.transform.position = WayPoint33.transform.position;
		}
		if (car3track == 3) 
		{
			Tracker3.transform.position = WayPoint34.transform.position;
		}
		if (car3track == 4) 
		{
			Tracker3.transform.position = WayPoint35.transform.position;
		}
	}
	public IEnumerator MainMenuAnim()
	{
		yield return new WaitForSeconds (5.0f);
		Camera2.SetActive (true);
		Camera1.SetActive (false);
		yield return new WaitForSeconds (5.0f);
		Camera3.SetActive (true);
		Camera2.SetActive (false);
		yield return new WaitForSeconds (5.0f);
		Camera1.SetActive (true);
		Camera3.SetActive (false);
	}
}

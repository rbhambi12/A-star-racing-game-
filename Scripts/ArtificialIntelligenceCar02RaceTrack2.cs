using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtificialIntelligenceCar02RaceTrack2 : MonoBehaviour 
{
	public int TrackerNumber;
	public GameObject WaypointTracker;
	public GameObject Waypoint01;
	public GameObject Waypoint02;
	public GameObject Waypoint03;
	public GameObject Waypoint04;
	public GameObject Waypoint05;
	public GameObject Waypoint06;
	public GameObject Waypoint07;
	public GameObject Waypoint08;
	public GameObject Waypoint09;
	public GameObject Waypoint10;
	public GameObject Waypoint11;
	public GameObject Waypoint12;
	public GameObject Waypoint13;
	public GameObject Waypoint14;
	public GameObject Waypoint15;
	public GameObject Waypoint16;
	public GameObject Waypoint17;
	public GameObject Waypoint18;
	public GameObject Waypoint19;
	public GameObject Waypoint20;
	public GameObject Waypoint21;
	public GameObject Waypoint22;
	public GameObject Waypoint23;
	public void Start()
	{
		TrackerNumber = 1;		
	}
	public void Update()
	{
		switch (TrackerNumber) 
		{
		case 1:
			WaypointTracker.transform.position = Waypoint01.transform.position;
			break;

		case 2:
			WaypointTracker.transform.position = Waypoint02.transform.position;
			break;

		case 3:
			WaypointTracker.transform.position = Waypoint03.transform.position;
			break;

		case 4:
			WaypointTracker.transform.position = Waypoint04.transform.position;
			break;

		case 5:
			WaypointTracker.transform.position = Waypoint05.transform.position;
			break;

		case 6:
			WaypointTracker.transform.position = Waypoint06.transform.position;
			break;

		case 7:
			WaypointTracker.transform.position = Waypoint07.transform.position;
			break;

		case 8:
			WaypointTracker.transform.position = Waypoint08.transform.position;
			break;

		case 9:
			WaypointTracker.transform.position = Waypoint09.transform.position;
			break;

		case 10:
			WaypointTracker.transform.position = Waypoint10.transform.position;
			break;

		case 11:
			WaypointTracker.transform.position = Waypoint11.transform.position;
			break;

		case 12:
			WaypointTracker.transform.position = Waypoint12.transform.position;
			break;

		case 13:
			WaypointTracker.transform.position = Waypoint13.transform.position;
			break;

		case 14:
			WaypointTracker.transform.position = Waypoint14.transform.position;
			break;

		case 15:
			WaypointTracker.transform.position = Waypoint15.transform.position;
			break;

		case 16:
			WaypointTracker.transform.position = Waypoint16.transform.position;
			break;

		case 17:
			WaypointTracker.transform.position = Waypoint17.transform.position;
			break;

		case 18:
			WaypointTracker.transform.position = Waypoint18.transform.position;
			break;

		case 19:
			WaypointTracker.transform.position = Waypoint19.transform.position;
			break;

		case 20:
			WaypointTracker.transform.position = Waypoint20.transform.position;
			break;

		case 21:
			WaypointTracker.transform.position = Waypoint21.transform.position;
			break;

		case 22:
			WaypointTracker.transform.position = Waypoint22.transform.position;
			break;

		case 23:
			WaypointTracker.transform.position = Waypoint23.transform.position;
			break;
			}
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "EnemyCar2") {
			this.GetComponent<BoxCollider> ().enabled = false;
			StartCoroutine (UpdateTrackerNumber ());
		}
	}
	public IEnumerator UpdateTrackerNumber()
	{
		if (TrackerNumber == 23) 
		{
			TrackerNumber = 1;
		} 
		else
		{
			TrackerNumber += 1;
		}
		yield return new WaitForSeconds (0.3f);
		this.GetComponent<BoxCollider> ().enabled = true;
	}

}

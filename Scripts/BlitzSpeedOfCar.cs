using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BlitzSpeedOfCar : MonoBehaviour
{
	public float speed;
	public GameObject Car;
	public static float distance;
	public float inspectordistance;
	public CarSpeedometer Speed;
	public float speedms;
	public float distancefinish;
	public GameObject Finish;
	public void Awake()
	{
		Speed = Car.GetComponent<CarSpeedometer> ();
		distance = 0.0f;
	}
	public void Update()
	{
		distancefinish = Vector3.Distance (Car.transform.position, Finish.transform.position);
		speedms = Car.GetComponent<Rigidbody> ().velocity.magnitude;
		speed = speedms * 3.6f;
		Speed.ShowArrowAngle (speed);
		if (!WrongWayDetection.WrongWay&&!BlitzRaceFinishScript.PlayerFinishedRace)
			distance = distance + speedms * Time.deltaTime;
		else if(WrongWayDetection.WrongWay&&!BlitzRaceFinishScript.PlayerFinishedRace)
			distance = distance - speedms * Time.deltaTime;
		inspectordistance = distance;
		if (distance < 0)
			distance = 0.0f;
	}
}

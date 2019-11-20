using System.Collections;
using System.Collections.Generic;
using UnityEngine; //UnityEngine is the main namespace of the Unity game engine.
public class CarCollisionEnter : MonoBehaviour // The Carcollisionenter class is a child class of the monobehaviour class. This is done so that we can attach the script to the gameobject which is otherwise not allowed.
{
	public GameObject Car;// Declaring a GameObject named Car
	public GameObject Checkpoint1;// Declaring a GameObject named Checkpoint1
	public GameObject Checkpoint2;// Declaring a GameObject named Checkpoint2
	public GameObject Checkpoint3;// Declaring a GameObject named Checkpoint3
	public GameObject Checkpoint4;// Declaring a GameObject named Checkpoint4
	public GameObject Checkpoint5;// Declaring a GameObject named Checkpoint5
	public GameObject Checkpoint6;// Declaring a GameObject named Checkpoint6
	public GameObject Checkpoint7;// Declaring a GameObject named Checkpoint7
	public GameObject Finish;// Declaring a GameObject named Finish
	public void Update() //called every frame
	{
			if(Input.GetButtonDown("NewCar")) // Check whether the user is pressing down the NewCar button which is n on the keyboard
			{// if the user is pressing down the NewCar button key, then do the following otherwise do nothing.

				switch (CheckPointScript.noofcheckpoints)// Using a switch case statement to switch between different values of the number of checkpoints in the checkpoint script.
				{
			case 0: // if CheckPointScript.noofcheckpoints is equal to zero, then do the following
				Car.SetActive (false);// Deactivate the car GameObject. i.e., deactivate the player car.
				Car.transform.position = Finish.transform.position;// Set the position of the car as the position of the checkpoint.
				Car.SetActive (true); // Activate the car again.
				break;
			case 1:// if CheckpointScript.noofcheckpoints is equal to one, then do the following
				Car.SetActive (false);// Deactivate the player car
				Car.transform.position = Checkpoint1.transform.position;// Set player car position to Checkpoint one position
				Car.SetActive (true);// Activate the car
					break;
			case 2:				Car.SetActive (false);// Deactivate the player car.
					Car.transform.position = Checkpoint2.transform.position;// Set the car's position to checkpoint2's position
				Car.SetActive (true);// Reactivate the player car so that the player can continue the race.

					break;
			case 3:				Car.SetActive (false);// Deactivate the player car.
				
				Car.transform.position = Checkpoint3.transform.position;// Set the car's position to checkpoint3's position
				Car.SetActive (true); // Reactivate the player car so that the player can continue the race.

					break;
			case 4:				Car.SetActive (false);// Deactivate the player car.
				
				Car.transform.position = Checkpoint4.transform.position; // Set the car's position to checkpoint4's position
				Car.SetActive (true); // Reactivate the player car so that the player can continue the race.

					break;
			case 5:				Car.SetActive (false);// Deactivate the player car.
				
				Car.transform.position = Checkpoint5.transform.position; // Set the car's position to checkpoint5's position
				Car.SetActive (true); // Reactivate the player car so that the player can continue the race.

					break;
			case 6:				Car.SetActive (false);// Deactivate the player car.
				
				Car.transform.position = Checkpoint6.transform.position;// Set the car's position to checkpoint6's position
				Car.SetActive (true); // Reactivate the player car so that the player can continue the race.

					break;
			case 7:				Car.SetActive (false);// Deactivate the player car.
				
				Car.transform.position = Checkpoint7.transform.position; // Set the car's position to checkpoint7's position
				Car.SetActive (true); // Reactivate the player car so that the player can continue the race.

					break;
				}
			}
		}
	}


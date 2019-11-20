using System.Collections;
using System.Collections.Generic;
using UnityEngine;// Main namespace.
using UnityEngine.UI;// Used to access Text script. 
using UnityStandardAssets.Vehicles.Car;// Used to access CarController, CarAIControl, CarUserControl etc.
using UnityEngine.AI;// Used to access NavMeshAgent.
public class CountDownScript : MonoBehaviour 
{
	public GameObject CountDown;// Define 26 gameObjects because all of them are needed for different purposes. 
	public GameObject Car1;
	public GameObject Car2;
	public GameObject Car3;
	public GameObject Car4;
	public GameObject Car5;
	public GameObject GameManager;
	public GameObject LapPanel;
	public GameObject LapNumberPanel;
	public AudioSource CountDownAudio;// Define three audiosources.
	public AudioSource GO;
	public AudioSource bgm;
	public GameObject RedPanel;
	public GameObject YellowPanel;
	public GameObject GreenPanel;
	public GameObject BlackPanel;
	public GameObject DistanceCheckpoints;
	public GameObject Speed;
	public GameObject Arrow;
	public GameObject MiniMap;
	public GameObject CheckPoint1;
	public GameObject CheckPoint2;
	public GameObject CheckPoint3;
	public GameObject Progress;
	public GameObject ProgressText;
	public GameObject SpeedCounter;
	public GameObject Speedm;
	public GameObject NavMEshActivation;
	public void Start()// Called exactly once and automatically called by Unity. 
	{
		Car1.GetComponent<CarController> ().enabled = false;// Disable CarController script attached to the player car.
		Car1.GetComponent<CarUserControl> ().enabled = false;// Disable CarUserControl script attached to the player car so that the player cannot control the car.
		Car2.GetComponent<CarController> ().enabled = false;// Disable the CarController script attached to the car controlled by computer.
		Car2.GetComponent<CarAIControl> ().enabled = false;//Disable the CarAIControl script attached to the car controlled by computer so that computer also cannot control the car and start the race prematurely.
		Car3.GetComponent<CarController> ().enabled = false;// Disable the CarController script attached to the car controlled by computer.
		Car3.GetComponent<CarAIControl> ().enabled = false; //Disable the CarAIControl script attached to the car controlled by computer so that computer also cannot control the car and start the race prematurely.
		Car4.GetComponent<CarController> ().enabled = false;// Disable the CarController script attached to the car controlled by computer.
		Car4.GetComponent<CarAIControl> ().enabled = false; //Disable the CarAIControl script attached to the car controlled by computer so that computer also cannot control the car and start the race prematurely.
		Car5.GetComponent<CarController> ().enabled = false;// Disable the CarController script attached to the car controlled by computer.
		Car5.GetComponent<CarAIControl> ().enabled = false; //Disable the CarAIControl script attached to the car controlled by computer so that computer also cannot control the car and start the race prematurely.
		Car1.GetComponent<CarAIControlStartRace> ().enabled = false; // Disable the startrace script attached to both the player and ai cars.
		Car2.GetComponent<CarAIControlStartRace> ().enabled = false;
		Car3.GetComponent<CarAIControlStartRace> ().enabled = false;
		Car4.GetComponent<CarAIControlStartRace> ().enabled = false;
		Car5.GetComponent<CarAIControlStartRace> ().enabled = false;
		StartCoroutine (Counting ());// Calls co-routine Counting which does all the counting down. 
	}
	public void Update()// Called every frame but does nothing in this script.
	{
	}
	public IEnumerator Counting()// IEnumerator is a co-routine which is called by start function.
	{
		RedPanel.SetActive (true);// Activate the redpanel, greenpanel, yellowpanel and the blackpanel which show distances between the player car and the other four ai cars.
		GreenPanel.SetActive (true);
		YellowPanel.SetActive (true);
		BlackPanel.SetActive (true);
		DistanceCheckpoints.SetActive (true);// Activate the distancebetweencheckpoints gameobject so that distance between player car and checkpoints is calculated.
		Arrow.SetActive (true);// Activates the arrow.
		//Speed.SetActive (true);
		MiniMap.SetActive (true);// Shows the minimap.
		CheckPoint1.SetActive (true);// Shows the checkpoint text of the User Interface.
		CheckPoint2.SetActive (true);// Shows the checkpoint text of the User Interface.
		CheckPoint3.SetActive (true); // Shows the checkpoint text of the User Interface.
		Progress.SetActive (true);//Activates the progress gameobject which calculates how much the player has progressed in the race.
		ProgressText.SetActive (true);// Shows the progress text in the game.
		SpeedCounter.SetActive (true);// Activates the speedcounter which calculates speed of all cars in the game.
		Speedm.SetActive (true);// Activates the speedometer. 
		CountDown.GetComponent<Text> ().text = "3. GET READY";
		CountDownAudio.Play ();
		yield return new WaitForSeconds (.95f);
		CountDown.SetActive (false);
		CountDown.GetComponent<Text>().text="2. SET";
		CountDownAudio.Play ();
		CountDown.SetActive (true);
		yield return new WaitForSeconds (.95f);
		CountDown.SetActive (false);
		CountDown.GetComponent<Text> ().text = "1";
		CountDownAudio.Play ();
		CountDown.SetActive (true);
		yield return new WaitForSeconds (.95f);
		CountDown.SetActive (false);
		CountDown.GetComponent<Text> ().text = "GO!";
		GO.Play ();
		bgm.Play ();
		CountDown.SetActive (true);
		LapPanel.SetActive (true);
		LapNumberPanel.SetActive (true);
		Car1.GetComponent<CarController> ().enabled = true;
		Car1.GetComponent<CarUserControl> ().enabled = true;
		Car2.GetComponent<CarController> ().enabled = true;
		Car2.GetComponent<CarAIControl> ().enabled = true;
		Car3.GetComponent<CarController> ().enabled = true;
		Car3.GetComponent<CarAIControl> ().enabled = true;
		Car4.GetComponent<CarController> ().enabled = true;
		Car4.GetComponent<CarAIControl> ().enabled = true;
		Car5.GetComponent<CarController> ().enabled = true;
		Car5.GetComponent<CarAIControl> ().enabled = true;
		NavMEshActivation.SetActive (true);
GameManager.GetComponent<LapTimeManager> ().enabled = true;
		yield return new WaitForSeconds (.95f);
		CountDown.SetActive (false);
		CountDown.GetComponent<Animator> ().enabled = false;
		this.gameObject.SetActive (false);
	}
}

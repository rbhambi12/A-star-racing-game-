using System.Collections;
using System.Collections.Generic;
using UnityEngine;// Main namespace of the Unity game engine.
using UnityEngine.UI;// This defines Text used in line 15 to 18.
using UnityEngine.SceneManagement;// This contains the definition for SceneManager.
public class DoPauseSpeedTrapRace02 : MonoBehaviour // Monobehaviour is a parent class from which DoPauseBlitzRaceTrack03 derives. In fact, all script classes derive from Monobehaviour.
{
	public GameObject RestartRace;// Defining GameObjects RestartRace, ReturnToMainMenu, ExitToWindows, ContinueRace and PausePanel.
	public GameObject ReturnToRaceMenu;
	public GameObject ExitToWindows;
	public GameObject ContinueRace;
	public GameObject PausePanel;
	public void Start() // Start function is called automatically by the Unity engine. Unlike the Update function, this function is called exactly once
	//NOTE: In Unity, scripts are case sensitive. Text is different from text and GameObject is different from gameobject. 
	{
		SpeedTrapCheckPointPosition.noofcheckpoints = 0;
		RestartRace.GetComponent<Text> ().text = "Restart Race";// Here, Text is the script attached to the RestartRace GameObject whereas the text with small t, is the property of the gameobject.
		ReturnToRaceMenu.GetComponent<Text> ().text = "Return To Race Menu"; // Assign return to race menu to the return to race menu text.
		ExitToWindows.GetComponent<Text> ().text = "Exit To Windows";// Similarly, assign exit to windows and continue race to the ExitToWindows and ContinueRace GameObjects respectively.
		ContinueRace.GetComponent<Text> ().text = "Continue Race";
	}
	public void Update()// Update is called  every frame automatically by the Unity engine. First, Awake is called, then Start and then Update
	{
		if (Input.GetButtonDown ("Cancel")) // If the user is pressing down the cancel button which is the Escape key, then do the following
		{
			PausePanel.SetActive (true); // Activate the pause panel. That is show the pause panel.
			Time.timeScale = 0; // Freeze the gameplay so that game is paused.
		}
	}
	public void RaceRestart() // User defined function. This function is NOT called automatically by Unity. It is instead called by a button.
	{

		SceneManager.LoadScene (10); // Load scene with index number 8 which is actually the same scene again.
		Time.timeScale = 1; // Restore the time in game such that one second in the game is equal to one second in real life. 
		PausePanel.SetActive (false); // Close the pause panel so that the user can race.
	}
	public void ReturnToMenuRace() // This is also a user defined function called by a button.
	{
		SceneManager.LoadScene (1); // Load scene with index number 1 which is the race menu where you can select the car and track.
		Time.timeScale = 1; // Restore the time in the game such that one second in the game is one second in real life.
		PausePanel.SetActive (false);// Close the pause panel.
	}
	public void RaceContinue() //This is a user defined function called by a button
	{
		Time.timeScale = 1; //We simply need to continue race. So, restore the normal time in the game.
		PausePanel.SetActive (false);// Close the pause panel.
	}
	public void ExitToWindow() // This function does not work in the Unity Editor. This works only in the standalone build of the game.
	{
		Time.timeScale = 1;// First, restore the normal time in gameplay.
		PausePanel.SetActive (false); // Close the pause panel by deactivating it.
		//NOTE: SetActive only deactivates the gameobject. It does not destroy it. By this, I mean, PausePanel still remains in the scene, but not visible to the player. 
		// Destroying an important gameobject like Pause Panel is not recommended. You can reuse it many times if you have not destroyed it, but once it is destroyed, you cannot do anything.
		Application.Quit (); // Quit the player application i.e., the standalone application. This method is non-functional in the game engine.
	}
}


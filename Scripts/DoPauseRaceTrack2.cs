using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DoPauseRaceTrack2 : MonoBehaviour
{
	public GameObject RestartRace;
	public GameObject ReturnToRaceMenu;
	public GameObject ExitToWindows;
	public GameObject ContinueRace;
	public GameObject PausePanel;
	public void Start()
	{
		RestartRace.GetComponent<Text> ().text = "Restart Race";
		ReturnToRaceMenu.GetComponent<Text> ().text = "Return To Race Menu";
		ExitToWindows.GetComponent<Text> ().text = "Exit To Windows";
		ContinueRace.GetComponent<Text> ().text = "Continue Race";
	}
	public void Update()
	{
		if (Input.GetButtonDown ("Cancel")) 
		{
			PausePanel.SetActive (true);
			Time.timeScale = 0;
		}
	}
	public void RaceRestart()
	{
		SceneManager.LoadScene (3);
		Time.timeScale = 1;
		PausePanel.SetActive (false);
	}
	public void ReturnToMenuRace()
	{
		SceneManager.LoadScene (1);
		Time.timeScale = 1;
		PausePanel.SetActive (false);
	}
	public void RaceContinue()
	{
		Time.timeScale = 1;
		PausePanel.SetActive (false);
	}
	public void ExitToWindow()
	{
		Time.timeScale = 1;
		PausePanel.SetActive (false);
		Application.Quit ();
	}
}


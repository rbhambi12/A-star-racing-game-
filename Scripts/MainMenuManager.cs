using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour 
{
	public GameObject PlayGame;
	public GameObject Options;
	public GameObject QuitGame;
	public GameObject GameName;
	public GameObject AboutGame;
	public GameObject AboutGamePanel;
	public GameObject ReturnToMainMenu;
	public GameObject Credits;
	public GameObject CreditPanel;
	public GameObject[] PeopleCredit;
	public GameObject Unity;
	public GameObject Engine;
	public GameObject Designer;
	public GameObject Programmer;
	public IEnumerator CreditEnd()
	{

		yield return new WaitForSeconds (12f);
		CreditPanel.SetActive (false);

	}
	public void Awake()
	{
		PlayGame.GetComponent<Text> ().text = "Play Game";
		Options.GetComponent<Text> ().text = "Options";
		QuitGame.GetComponent<Text> ().text = "Quit Game";
		AboutGame.GetComponent<Text> ().text = "About Game";
		GameName.GetComponent<Text> ().text = "A-Star Racing";
		ReturnToMainMenu.GetComponent<Text> ().text = "<<Return To Main Menu";
		Credits.GetComponent<Text> ().text = "Credits";
		PeopleCredit [0].GetComponent<Text> ().text = "Uday Dua";
		PeopleCredit [1].GetComponent<Text> ().text = "Rohini";
		PeopleCredit [2].GetComponent<Text> ().text = "Aman Brar";
		Engine.GetComponent<Text> ().text = "Game Engine";
		Unity.GetComponent<Text> ().text = "Unity";
		Designer.GetComponent<Text> ().text = "Designers";
		Programmer.GetComponent<Text> ().text = "Lead Programmer";
	}	
	public void PlayGames()
	{
		SceneManager.LoadScene (1);
	}
	public void QuitGames()
	{
		Application.Quit ();		
	}
	public void OptionsOpen()
	{
		SceneManager.LoadScene (4);
	}
	public void AboutGames()
	{
		AboutGamePanel.SetActive (true);
	}
	public void ReturnMainMenu()
	{
		AboutGamePanel.SetActive (false);
	}
	public void Credit()
	{
		CreditPanel.SetActive (true);
		StartCoroutine (CreditEnd ());
	}
}

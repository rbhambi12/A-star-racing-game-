using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
public class BlitzCountDownManager : MonoBehaviour 
{
	public GameObject CountDown;
	public GameObject Car1;
	public GameObject BlitzTimeManager;
	public GameObject RemainingTimePanel;
	public AudioSource CountDownAudio;
	public AudioSource GO;
	public AudioSource bgm;
	public void Start()
	{
		Car1.GetComponent<CarController> ().enabled = false;
		Car1.GetComponent<CarUserControl> ().enabled = false;
		StartCoroutine (Counting ());
	}
	public void Update()
	{
	}
	public IEnumerator Counting()
	{
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
		RemainingTimePanel.SetActive (true);
		Car1.GetComponent<CarController> ().enabled = true;
		Car1.GetComponent<CarUserControl> ().enabled = true;
		BlitzTimeManager.SetActive (true);
		yield return new WaitForSeconds (.95f);
		CountDown.SetActive (false);
		CountDown.GetComponent<Animator> ().enabled = false;
		this.gameObject.SetActive (false);
	}
}

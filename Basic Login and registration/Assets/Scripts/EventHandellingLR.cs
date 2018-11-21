using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;


public class EventHandellingLR : MonoBehaviour {
	public Image RegistrationPanel;
	public Image LoginPanel;
	public Image MainPanel;

	//Buttons Declaration...
	public static Button LoginJM = LoginJM.GetComponent<Button> ();
	public static Button RegJM = RegJM.GetComponent<Button> ();
	public static Button RegBack = RegBack.GetComponent<Button> ();
	//public Button LoginLI = LoginLI.GetComponent<Button> ();             //for linking with the game


	// Use this for initialization
	void Start () {
		LoginPanel.gameObject.SetActive (true);
		RegistrationPanel.gameObject.SetActive (false);
		MainPanel.gameObject.SetActive (false);

		//LoginLI.onClick.AddListener (onClickMethodLJM);        //for linking with the game
		LoginJM.onClick.AddListener (onClickMethodLJM);
		RegBack.onClick.AddListener (onClickMethodRB);
		RegJM.onClick.AddListener (onClickMethodRJM);
	}

	//Methods Connected to the Buttons

	//This method is to link up with the game... Party!!
	/*public void onClickMethodLJM() {

	}*/

	public void onClickMethodLJM() {

		MainPanel.gameObject.SetActive (true);
		LoginPanel.gameObject.SetActive (false);
		RegistrationPanel.gameObject.SetActive (true);
		
	}

	public void onClickMethodRB() {

		MainPanel.gameObject.SetActive (true);
		RegistrationPanel.gameObject.SetActive (false);
		LoginPanel.gameObject.SetActive (true);

	}

	public void onClickMethodRJM() {

//		StartCoroutine (NRegisterScript.StoreData ());
		MainPanel.gameObject.SetActive (true);
		RegistrationPanel.gameObject.SetActive (false);
		LoginPanel.gameObject.SetActive (true);

	}
	//Method Endings
}

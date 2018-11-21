using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameControlLOD : MonoBehaviour {


	public static GameControlLOD control; 
	//Panel Controling Variables
	public GameObject LoadingPanel;
	public GameObject MainPanel;
	public GameObject LoginPanel;
	public int a;
	public int b;
	public Button S1;
	public Button S2;
	public Text Score3;
	public Text Score4;


	//The Strings are to be sent to the other scripts.
	public String Authstatus;
	public String Authstatus1;
	//Login process variables

	// Use this for initialization
	void Awake () {

		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this) {
			Destroy (gameObject);
		}
		LoginPanel.gameObject.SetActive (true);
		MainPanel.gameObject.SetActive (true);
		LoadingPanel.gameObject.SetActive (false);
	}

	void Start(){
		Score3.text = a.ToString();
		Score4.text = b.ToString();
	}

	void Update(){
		//Score3.text = a.ToString();
		//Score4.text = b.ToString();

	
	}
	// Update is called once per frame
	public void onClickAdd1(){
		//a = Convert.ToInt32(Score3.text);
		a = a + 1;
		Score3.text = a.ToString();
	}
	public void onClickAdd2(){
		//b = Convert.ToInt32(Score4.text);
		b = b + 1;
		Score4.text = b.ToString();
	}
}

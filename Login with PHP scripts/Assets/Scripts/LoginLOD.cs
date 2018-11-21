using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class LoginLOD : MonoBehaviour {

	public GameObject LoadingPanel;
	public GameObject MainPanel;
	public GameObject LoginPanel;

	public string emailid;
	public string password;	
	public string register_url = "http://g4g.co.in/aog/TextLOD.php";
	public string register1_url = "http://g4g.co.in/aog/RetrieveLOD.php";
	public InputField authstatus;
	public InputField authstatus1;


	public int v1;
	public int v2 = 0;
	public int v3 = 0;

	public int check;

	public string data;

	//public Text Scoreaa;
	//public Text Scorebb;

	void Awake(){
		//authstatus.text = "testerFailed";
	}

	// Use this for initialization


	//Will be initialised when we press login button in login panel...	
	public void OnclickEvent(){
		LoadingPanel.gameObject.SetActive (true);
		StartCoroutine (StoreData ());
		StartCoroutine (GetData ());
		MainPanel.gameObject.SetActive (true);
		//LoginPanel.gameObject.SetActive (false);
	}

	//Login Coroutine...

	public IEnumerator StoreData()
	{
		
		Debug.Log ("Into Actual coroutine!!");
		GameControlLOD.control.Authstatus = (authstatus.text).ToString ();
		GameControlLOD.control.Authstatus1 = (authstatus1.text).ToString ();
		emailid = (authstatus.text).ToString();
		password = (authstatus1.text).ToString();
		WWWForm form = new WWWForm ();
		form.AddField ("emailid1", emailid);
		form.AddField ("pass1", password);
		WWW download = new WWW( register_url, form );

		yield return download;
	} 


	//Fetching the Data...

	public IEnumerator GetData()
	{
		Debug.Log ("Into Actual coroutine!!");
		emailid = (authstatus.text).ToString();
		WWWForm form = new WWWForm ();
		form.AddField ("emailid1", emailid);
		WWW download = new WWW( register1_url, form );
		yield return download;
		data = download.text;
		string[] values = data.Split("#"[0]); 

		//Trial game retrieving
		v1 = int.Parse(values[0]);
		v2 = int.Parse(values[1]);
		v3 = int.Parse(values[2]);

		LoadingPanel.gameObject.SetActive (false);
		LoginPanel.gameObject.SetActive (false);
		GameControlLOD.control.a = v2;
		GameControlLOD.control.b = v3;
	
	} 

}

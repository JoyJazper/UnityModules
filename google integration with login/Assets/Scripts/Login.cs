using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Login : MonoBehaviour {
	

	//public InputField EmailIdInputField;
	//public InputField PasswordInputField;
	public Button RegisterB;

	public Text EmailErrorText;
	public Text PasswordErrorText;
	public string answer;

	public string emailid;
	//public string password;	
	public string register_url = "http://g4g.co.in/aog/Text1.php";
	public Text authstatus;

	void Awake(){
		PlayGamesPlatform.DebugLogEnabled = true;
		PlayGamesPlatform.Activate ();

	}

	// Use this for initialization
	void Start() {

		Social.localUser.Authenticate ((bool success) => {
			if (success) {
				authstatus.text = Social.localUser.userName;
			
			}

		});
	
	}

	public void onClickMethod(){
		StartCoroutine (StoreData ());
	}


	public IEnumerator StoreData()
	{
		Debug.Log ("Into Actual coroutine!!");
		//username = UserNameInputField.text;
		emailid = authstatus.text;
		//password = PasswordInputField.text;
		WWWForm form = new WWWForm ();
		form.AddField ("username1", emailid);
		form.AddField ("emailid1", emailid);
		//form.AddField ("pa", password);

		//Debug.Log("username = " + username);
		Debug.Log("emailid= " + emailid) ;
		//	Debug.Log("password= " + password) ;

		WWW download = new WWW( register_url, form );
		yield return download;
		if (download.error != null) {
			Debug.LogError ("We did not get the return signal.");
		} else {
			Debug.Log ("Got the signal succesfully!!");
		}
		answer = download.text;
		Debug.Log(answer);

		Debug.Log ("success");
		if (answer == "Successfully Registered") {
			Debug.Log ("success");
		} 
		else 
		{
			Debug.Log ("Email already exist");
		}
	} 


}

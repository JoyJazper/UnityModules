using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class NRegisterScript : MonoBehaviour {

	public InputField EmailIdInputField;
	public InputField PasswordInputField;
	public Button RegisterB;

	public Text EmailErrorText;
	public Text PasswordErrorText;
	public string answer;

	public string emailid;
	public string password;	
	public string register_url = "http://localhost/aogdata/RegPHP.php";

	public Image loginpanel;

	void start () {
		Button Btn = RegisterB.GetComponent<Button> ();
		Btn.onClick.AddListener (onClickMethod);

	}

		public IEnumerator StoreData()
		{
			Debug.Log ("Into Actual coroutine!!");
			//username = UserNameInputField.text;
			emailid = EmailIdInputField.text;
			password = PasswordInputField.text;
			WWWForm form = new WWWForm ();
			//form.AddField ("username1", username);
			form.AddField ("userID", emailid);
			//form.AddField ("pa", password);

			//Debug.Log("username = " + username);
			Debug.Log("emailid= " + emailid) ;
			Debug.Log("password= " + password) ;

			WWW download = new WWW( register_url, form );
			yield return download;
			if (download.error != null) {
				Debug.LogError ("We did not get the return signal.");
			} else {
				Debug.Log ("Got the signal succesfully!!");
			}
			answer = download.text;
			Debug.Log(answer);

			Debug.Log ("success"+ download);
			if (answer == "Successfully Registered") {
				Debug.Log ("success");
			} 
			else 
			{
				Debug.Log ("Email already exist");
			}
		} 
	public void onClickMethod(){
		StartCoroutine (StoreData ());
	}
}

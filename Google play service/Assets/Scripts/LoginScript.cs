using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour {

	public InputField UserNameInputField;
	public InputField PasswordInputField;

	string login_url = "http://www.vuritis.com/AOG/Login.php";

	public string username;
	public string password;
	public string answer;


	void Start () {
	
	}
	
	public void LoginButton()
	{



			StartCoroutine (RetrieveData ());
		} 

	IEnumerator RetrieveData()
	{

		username = UserNameInputField.text;
		password = PasswordInputField.text;

		Debug.Log ("username" + username);
		Debug.Log ("password" + password);

		WWWForm form = new WWWForm ();
		form.AddField ("username1", username);
		form.AddField ("password1", password);

		WWW download1 = new WWW (login_url, form); 
		yield return download1;

		answer = download1.text.ToString ();
		Debug.Log ("Ans  " + answer);

		if (answer == "success") 
		{
			Application.LoadLevel ("GameScreen");

		} 
		else 
		{
			Debug.Log ("mismatch");
		}
	}

	void Update () {
	
	}
}

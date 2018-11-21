using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class registerpanel : MonoBehaviour {

	public InputField UserNameInputField;
	public InputField EmailIdInputField;
	public InputField PasswordInputField;

	public Text UserNameErrorText;
	public Text EmailErrorText;
	public Text PasswordErrorText;

	public string username;
	public string emailid;
	public string password;	
	string register_url = "http://www.vuritis.com/dr/Register1.php";

	public Image registerspanel;

	public string answer;
	// Use this for initialization
	void Start () {
		registerspanel.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (UserNameInputField.text == "") {
			UserNameInputField.GetComponent<InputField> ().placeholder.GetComponent<Text> ().text = "Enter User Name...";
	
		}
	}
	public void NewUserButton()
	{
		registerspanel.gameObject.SetActive (true);
	}
	public void BackButton()
	{
		registerspanel.gameObject.SetActive (false);
	}	

	public void RegisterButton()
	{
		string UserName = UserNameInputField.text;
		string UserEmail = EmailIdInputField.text;
		string UserPassword = PasswordInputField.text;

		if ((UserNameInputField.text != "") && (EmailIdInputField.text != "") && (PasswordInputField.text != "")) 
		{
			if((!IsValidUserName(UserName)) && (IsvalidEmailId(UserEmail)))
			{
				UserNameErrorText.text = "Username should be minimum 6 to 12 characters";
				EmailErrorText.text = "";

			}
			if((IsValidUserName(UserName)) && (!IsvalidEmailId(UserEmail)))
			{
				EmailErrorText.text = "Invalid Email Format";
				UserNameErrorText.text = "";

			}

			if((IsValidUserName(UserName)) && (IsvalidEmailId(UserEmail)))
			{

				StartCoroutine (StoreData ());
				EmailErrorText.text = "";
				UserNameErrorText.text = "";

			}

			if((!IsValidUserName(UserName)) && (!IsvalidEmailId(UserEmail)))
			{
				EmailErrorText.text = "Invalid Email Format";
				UserNameErrorText.text = "Username should be minimum 6 to 12 characters...";
			}

			if ((!IsValidPassword (UserPassword))) 
			{
				PasswordErrorText.text = "Password should be minimum 6 to 12 characters and no special characters allowed";
			}

		}


	}


	IEnumerator StoreData()
	{
		username = UserNameInputField.text;
		emailid = EmailIdInputField.text;
		password = PasswordInputField.text;
		WWWForm form = new WWWForm ();
		form.AddField ("username1", username);
		form.AddField ("emailid1", emailid);
		form.AddField ("password1", password);

		Debug.Log("username = " + username);
		Debug.Log("emailid= " + form) ;

		WWW download = new WWW( register_url, form );
		yield return download;
		answer = download.text.ToString ();
		//DidnotenterText.text = "Loading";
		//if(answer)
		if (answer == "Successfully Registered") {
			Debug.Log ("success");
			//RegisterCheckText.text = "Successfully Registered";
		} 
		else 
		{
			Debug.Log ("User Name or Email already exist");
			//RegisterCheckText.text = "Username or Email Already Existed";
		}
		/*if (!string.IsNullOrEmpty (download.error)) {
			print ("Error downloading: " + download.error);

			ErrorString = download.error;
			ErrorMsg.text = ErrorString;

		}*/
		} 

	public static bool IsvalidEmailId(string InputEmail)
	{
		Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,5})+)$");
		Match match = regex.Match (InputEmail);
		if (match.Success)
			return true;
		else
			return false;
	}
	public static bool IsValidUserName(string InputUsername)
	{
		Regex regex1 = new Regex("^[a-zA-Z0-9]{6,12}$");
		Match match1 = regex1.Match (InputUsername);
		if (match1.Success)
			return true;
		else
			return false;
	}



	public static bool IsValidPassword(string InputPassword)
	{
		Regex regex2 = new Regex("^[a-zA-Z0-9]{6,12}$");
		Match match2 = regex2.Match (InputPassword);
		if (match2.Success)
			return true;
		else
			return false;
	}

}

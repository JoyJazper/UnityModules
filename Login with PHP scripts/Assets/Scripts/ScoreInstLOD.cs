using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class ScoreInstLOD : MonoBehaviour {

	public string answer;

	public GameObject LoadingPanel;
	public GameObject MainPanel;

	public int Score1;
	public int Score2;
	public string emailid;
	public string password;	
	public string register_url = "http://g4g.co.in/aog/ScoreTextLOD.php";

	/*public void onClickMethod(){
		emailid = GameControlLOD.control.Authstatus;
		Score1 = GameControlLOD.control.a;
		Score2 = GameControlLOD.control.b;
		StartCoroutine (SaveData ());
		//StartCoroutine (BreakWait ());// This is only used if button is provided.
	}*/



	public void OnApplicationQuit()
	{
		emailid = GameControlLOD.control.Authstatus;
		Score1 = GameControlLOD.control.a;
		Score2 = GameControlLOD.control.b;
		StartCoroutine (SaveData ());
		Application.Quit ();


	}

	/*public IEnumerator BreakWait(){

		Debug.Log ("In here for waiting");
		yield return new WaitForSeconds (0.2f);

	}*/

	public IEnumerator SaveData()
	{
		Debug.Log ("Into Actual Saving coroutine!!");
		WWWForm form = new WWWForm ();
		form.AddField ("Score1", Score1);
		form.AddField ("Score2", Score2);
		form.AddField ("emailid1", emailid);
		Debug.Log (emailid+ "and" + Score1+ "and" + Score2);
		WWW download10 = new WWW( register_url, form );
		yield return download10;
		Debug.Log (download10);
	} 


}




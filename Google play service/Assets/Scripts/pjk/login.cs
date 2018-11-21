using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;


public class login : MonoBehaviour {
	public string UserName;
	public string UserID;
	//public string ProfilePic;
	void Awake()
	{
		Social.localUser.Authenticate (ProcessAuthentication);
	}

	private void ProcessAuthentication (bool success) 
	{
		if (success) 
		{
			UserName  = Social.localUser.userName; // UserName
			UserID      = Social.localUser.id; // UserID
			//ProfilePic    =Social.localUser.image; // ProfilePic
		}
		else
		{
			Debug.LogWarning ("Failed to authenticate");
		}
	}
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
public class LoginCall1 : MonoBehaviour { 
public Text nerds;
	//public Text id;

	void Start()
	{
		PlayGamesPlatform.Activate ();
	}

	void Awake()
	{
		PlayGamesPlatform.DebugLogEnabled = true;
		PlayGamesPlatform.Activate ();
		Social.localUser.Authenticate ((bool success) => {
			// handle success or failure
			if (success) {
				//print ("Login true");
				nerds.text = ("succes"+Social.localUser.id);

			
			} else
				nerds.text = ("Google Login failed");
				//Debug.Log ("Google Login failed");
		});
			}
}     
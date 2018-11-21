using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LoginCall : MonoBehaviour {
	
		public Text ProfilePopUpText;
		//public string signOutButtonMsg;
		public void ProfileTextInfo(string message)
		{
			ProfilePopUpText.text = message;
		}
	}
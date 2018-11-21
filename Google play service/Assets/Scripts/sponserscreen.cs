using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class sponserscreen : MonoBehaviour {
	public Image sponsorpanel;
	public Image CompanyPanel;
	// Use this for initialization
	void Start () {
		sponsorpanel.gameObject.SetActive (true);
		CompanyPanel.gameObject.SetActive (true);
		Invoke ("SponsorButton", 2.0f);
		Invoke ("CompanyButton", 4.0f);
	}
	

	void Update () {
	
	}
	public void SponsorButton()
	{
		
		CompanyPanel.gameObject.SetActive (false);

	}
	public void CompanyButton()
	{
		CompanyPanel.gameObject.SetActive (false);
		Application.LoadLevel ("LoginScreen");
	
	}

}

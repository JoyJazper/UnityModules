using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class setting : MonoBehaviour {
	public Image Settingpanel;

	// Use this for initialization
	void Start () {
		Settingpanel.gameObject.SetActive (false);

	}

	// Update is called once per frame
	void Update () {

	}
	public void settingButton()
	{
		Settingpanel.gameObject.SetActive (true);
	}
	public void settingClose()
	{
		Settingpanel.gameObject.SetActive (false);
	}

}
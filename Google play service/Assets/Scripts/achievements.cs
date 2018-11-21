using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class achievements: MonoBehaviour {
	public Image Achievementpanel;
	// Use this for initialization
	void Start () {
		Achievementpanel.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void achieveButton()
	{
		Achievementpanel.gameObject.SetActive (true);
	}
	public void achieveClose()
	{
		Achievementpanel.gameObject.SetActive (false);
	}
}
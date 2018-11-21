using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class shopscript2 : MonoBehaviour {
	public Image Shoppanel;
	// Use this for initialization
	void Start () {
		Shoppanel.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}
	public void Event11Button()
	{
		Shoppanel.gameObject.SetActive (true);
	}
	public void Event12Button()
	{
		Shoppanel.gameObject.SetActive (false);
	}
}
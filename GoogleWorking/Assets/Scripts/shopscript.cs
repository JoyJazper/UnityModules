using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class shopscript : MonoBehaviour {
	public Image Shoppanel;
	// Use this for initialization
	void Start () {
		Shoppanel.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Event1Button()
	{
		Shoppanel.gameObject.SetActive (true);
}
	public void Event2Button()
	{
		Shoppanel.gameObject.SetActive (false);
	}
}
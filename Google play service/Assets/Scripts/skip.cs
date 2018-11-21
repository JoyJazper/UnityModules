using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class skip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void skipbutton()
	{
		Application.LoadLevel ("GameScreen");
	}
}

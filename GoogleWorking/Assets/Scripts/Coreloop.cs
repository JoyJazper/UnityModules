using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coreloop : MonoBehaviour {
	public GameObject gasbuiliding;

	// Use this for initialization
	void Start () {
    		gasbuiliding.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Game2()
	{
		Application.LoadLevel("GameScreen");

	}
	public void gasbuild()
	{
		gasbuiliding.SetActive (true);
	}
}

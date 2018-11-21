using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
	public GameObject MainPanel;
	public GameObject NetworkPanel;
	public GameObject TopologyPanel;
	public GameObject TreePanel;

	void Awake()
	{
		MainPanel.SetActive (true);
		GetComponent<AudioSource>().Play();
	}

	public void NET()
	{
		MainPanel.SetActive (false);
		NetworkPanel.SetActive (true);
		TopologyPanel.SetActive (false);
		TreePanel.SetActive (false);

	}

	public void TOP()
	{
		MainPanel.SetActive (false);
		NetworkPanel.SetActive (false);
		TopologyPanel.SetActive (true);
		TreePanel.SetActive (false);

	}

	public void TOPT()
	{
		MainPanel.SetActive (false);
		NetworkPanel.SetActive (false);
		TopologyPanel.SetActive (false);
		TreePanel.SetActive (true);

	}

	public void Back()
	{
		MainPanel.SetActive (true);
		NetworkPanel.SetActive (false);
		TopologyPanel.SetActive (false);
		TreePanel.SetActive (false);
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
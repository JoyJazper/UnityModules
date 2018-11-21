using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randScript : MonoBehaviour {
	
	public Text displayText;
	public int oldRandNum;
	public int randNum;
	void Start()
	{
		randNum = 0;
		oldRandNum = 0;
	}

	public void ButtonClick()
	{
		randNum = Random.Range (1, 6);
		if (oldRandNum != randNum) 
		{
			displayText.text = randNum.ToString ();
		}
		else 
		{
			ButtonClick ();
		}
		oldRandNum = randNum;
	}
}

using UnityEngine;
using System.Collections;
public class glowObject : MonoBehaviour 
{
	private Color StartColor;
	public bool selected;
	public Color MouseOverColor = Color;
	public static Color Color = new Color (255, 165, 0, 1);

	void Start () 
	{
		if(GetComponent<Renderer>() != null)
		if( gameObject.GetComponent<Renderer>().material != null)
			StartColor =  gameObject.GetComponent<Renderer>().material.color;
	}

	void OnMouseEnter()
	{
		selected=true;
		Debug.Log (gameObject.name);
		if(GetComponent<Renderer>() != null)
		if( gameObject.GetComponent<Renderer>().material != null)
			gameObject.GetComponent<Renderer>().material.color = MouseOverColor;
	}

	void OnMouseExit()
	{
		if(GetComponent<Renderer>() != null)
		if( gameObject.GetComponent<Renderer>().material != null)
			gameObject.GetComponent<Renderer>().material.color = StartColor;
	}
}
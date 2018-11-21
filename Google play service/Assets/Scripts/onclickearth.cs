using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class onclickearth : MonoBehaviour {
	public Image corepanel;

	void Start () {
		corepanel.gameObject.SetActive (false);
	}

	void Update () 
	{
		RaycastHit hit;

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

				if (Input.GetButtonDown ("Fire1")) 
				{
					
					if (Physics.Raycast(ray, out hit, 100))
					{
						
						if (hit.collider.CompareTag("Player"))
						{
							
							corepanel.gameObject.SetActive (true);
						}
			}
		}
	
	}    

	public void CoreLoopButton()
	{
		Application.LoadLevel("Core Loop");
	}
		
	public void OuterEarthButton()
	{
		Application.LoadLevel("OuterCoreEarth");
	}
}

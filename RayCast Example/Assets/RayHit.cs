using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayHit : MonoBehaviour
{
	public Transform GOC;
	void OnMouseDown(){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			Debug.Log ("9999999999999999");

			if (Physics.Raycast (ray, out hit, 100)) {
					//Debug.Log (Vector3 (ray.origin - hit.point));
					Debug.Log(ray.origin);
					Debug.Log(hit.point);
			Instantiate (GOC, hit.point, Quaternion.identity);

		    }
	}
	/*void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(transform.position, ray, out hit, 100.0f))
			Debug.Log("Found an object - distance: " + hit.distance);

		if (Physics.Raycast(ray, 1000))
			print("Hit something!");
	}*/
}
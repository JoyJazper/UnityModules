using UnityEngine;
using System.Collections;

public class PanCamera : MonoBehaviour {

	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			Vector3 touchdeltaPosition = Input.GetTouch (0).deltaPosition;
			transform.Translate (touchdeltaPosition.x * speed, touchdeltaPosition.y * speed, 0);
		}
	}
}

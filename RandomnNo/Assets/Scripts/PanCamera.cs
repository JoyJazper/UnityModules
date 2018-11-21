/*using UnityEngine;
using System.Collections;

public class PanCamera : MonoBehaviour {

	public float speed = 0.1f;
	public float MIN_X = 7f;
	public float MAX_X = 12f;
	public float MIN_Y = 8f;
	public float MAX_Y = 13f;
	public float MIN_Z = 10f;
	public float MAX_Z = 10f;
	public Vector3 nextPosition;
	public float moveSpeed;
	public int camAdjust = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			Vector3 touchdeltaPosition = Input.GetTouch (0).deltaPosition;
			transform.Translate (-touchdeltaPosition.x * speed*Time.deltaTime, -touchdeltaPosition.y * speed*Time.deltaTime, 0);
			//transform.Translate = Vector3.Lerp (-touchdeltaPosition.x * speed * Time.deltaTime, -touchdeltaPosition.y * speed * Time.deltaTime, 0);
			//transform.position.y = Terrain.activeTerrain.SampleHeight(transform.position) + camAdjust;
			transform.position = new Vector3(
				Mathf.Clamp(transform.position.x, MIN_X, MAX_X),
				Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y),
				Mathf.Clamp(transform.position.z, MIN_Z, MAX_Z));
			//transform.position = Vector3.LerpUnclamped (-touchdeltaPosition.x * speed * Time.deltaTime, -touchdeltaPosition.y * speed * Time.deltaTime, 0);
			//transform.position = Vector3.Lerp (touchdeltaPosition, transform.position, speed * Time.deltaTime);
			//transform.position = new Vector3 (Mathf.Lerp (minimum, maximum, Time.time), 0, 0);
			//float lerpValue = Mathf.Lerp (transform.position, 10f, Time.deltaTime * speed);
			//transform.eulerAngles = new Vector3 (lerpValue, 0, 0);
		}
	}
}









/*var nextPosition: Vector3; //or public Vector3 nextPosition; if in C#
var moveSpeed: float; //or public float moveSpeed; if in C#
transform.position = Vector3.Lerp(transform.position, nextPosition, Time.deltaTime * moveSpeed);


function Update()  //Or void Update() if in C#


Time.deltaTime;*/
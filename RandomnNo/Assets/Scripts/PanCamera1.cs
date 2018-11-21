/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanCamera1 : MonoBehaviour {


	private Vector2 worldStartPoint;

	void Update () {

		// only work with one touch
		if (Input.touchCount == 1) {
			Touch currentTouch = Input.GetTouch(0);

			if (currentTouch.phase == TouchPhase.Began) {
				this.worldStartPoint = this.getWorldPoint(currentTouch.position);
			}

			if (currentTouch.phase == TouchPhase.Moved) {
				Vector2 worldDelta = this.getWorldPoint(currentTouch.position) - this.worldStartPoint;

				Camera.main.transform.Translate(
					-worldDelta.x,
					-worldDelta.y,
					0
				);
			}
		}
	}

	// convert screen point to world point
	private Vector2 getWorldPoint (Vector2 screenPoint) {
		RaycastHit hit;
		Physics.Raycast(Camera.main.ScreenPointToRay(screenPoint), out hit);
		return hit.point;
	}
}


























// Credit to damien_oconnell from http://forum.unity3d.com/threads/39513-Click-drag-camera-movement
// for using the mouse displacement for calculating the amount of camera movement and panning code.
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PanCamera1 : MonoBehaviour 
{
	//
	// VARIABLES
	//

	public float turnSpeed = 4.0f;		// Speed of camera turning when mouse moves in along an axis
	public float panSpeed = 4.0f;		// Speed of the camera when being panned
	public float zoomSpeed = 4.0f;		// Speed of the camera going back and forth

	private Vector3 touchOrigin;	// Position of cursor when mouse dragging starts
	private bool isPanning;		// Is the camera being panned?
	private bool isRotating;	// Is the camera being rotated?
	private bool isZooming;		// Is the camera zooming?

	//
	// UPDATE
	//

	void Update () 
	{
		// Get the left mouse button
		if(Input.touchCount == 0)
		{
			// Get mouse origin
			touchOrigin = Input.touchPosition;
			isRotating = true;
		}

		// Get the right mouse button
		if(Input.touchCount == 1)
		{
			// Get mouse origin
			mouseOrigin = Input.mousePosition;
			isPanning = true;
		}

		// Get the middle mouse button
		if(Input.touchCount == 2)
		{
			// Get mouse origin
			mouseOrigin = Input.mousePosition;
			isZooming = true;
		}

		// Disable movements on button release
		if (!Input.GetMouseButton(0)) isRotating=false;
		if (!Input.GetMouseButton(1)) isPanning=false;
		if (!Input.GetMouseButton(2)) isZooming=false;

		// Rotate camera along X and Y axis
		if (isRotating)
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

			transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
			transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
		}

		// Move the camera on it's XY plane
		if (isPanning)
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

			Vector3 move = new Vector3(pos.x * panSpeed, pos.y * panSpeed, 0);
			transform.Translate(move, Space.Self);
		}

		// Move the camera linearly along Z axis
		if (isZooming)
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

			Vector3 move = pos.y * zoomSpeed * transform.forward; 
			transform.Translate(move, Space.World);
		}
	}
}























using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{
	public float moveSpeed = 50.0f; //Speed move with ASDW
	public float rotateSpeed = 70.0f; //Rotate speed when press QE
	public float zoomSpeed = 80.0f; //Zoom speed when you scroll in or out
	public float zoomRotate = 40.0f; //When the camera rotate a little while zooming
	public float zoomMin = 20.0f; //Minimun value to zoom in
	public float zoomMax = 60.0f; //Maximun value to zoom out

	void Start ()
	{
	
	}
	
	void Update () 
	{
		#region Move camera ASDW
		//Move the camera up, down, left and right
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
		}
		
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
		}
		
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
		}
		#endregion
		
		#region Zoom camera with Mouse ScrollWheel
		//Use the zoom with the scroll mouse button
		//Convert value to Int to avoid zoom problems(dont belive me?, remove it and try)
		if (Input.GetAxis("Mouse ScrollWheel") > 0 && transform.position.y > zoomMin)
		{
			if(transform.position.y > zoomRotate)
			{
				transform.position += Vector3.down * (int)(Time.deltaTime * zoomSpeed);
			}
			else
			{
				transform.position += Vector3.down * (int)(Time.deltaTime * zoomSpeed);
				transform.Rotate(Vector3.left * (int)(Time.deltaTime * zoomSpeed));
				
			}
		}
		
		if (Input.GetAxis("Mouse ScrollWheel") < 0 && transform.position.y < zoomMax)
		{
			if(transform.position.y < zoomRotate)
			{
				transform.position += Vector3.up * (int)(Time.deltaTime * zoomSpeed);
				transform.Rotate(Vector3.right * (int)(Time.deltaTime * zoomSpeed));
			}
			else
			{
				transform.position += Vector3.up * (int)(Time.deltaTime * zoomSpeed);
			}
		}
		#endregion
		
		#region Rotate camera with QE
		//Rotate the camera
		if (Input.GetKey(KeyCode.E))
		{
			Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0, 0.5f));
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				transform.RotateAround(hit.point, Vector3.up, rotateSpeed * Time.deltaTime);
			}
		}
		
		if (Input.GetKey(KeyCode.Q))
		{
			Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0, 0.5f));
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				transform.RotateAround(hit.point, -Vector3.up, rotateSpeed * Time.deltaTime);
			}
		}
		#endregion
		
	}
}
*/
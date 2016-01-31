using UnityEngine;
using System.Collections;

public class PinchZoom : MonoBehaviour
{
	
	public float perspectiveZoomSpeed = 0.5f;        
	public float orthoZoomSpeed = 0.5f;       
	public float perspectiveScrollSpeed = 2f;

	
	
	void Update()
	{
		

		if (Input.touchCount == 2)
		{
		
			Touch touchZero = Input.GetTouch(0);
			Touch touchOne = Input.GetTouch(1);
			
			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
			
			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

			GetComponent<Camera>().fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;
				
			GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, 15f, 80.1f);

		}
		

		
		
		if (!GetComponent<Camera>().orthographic)
		{
			GetComponent<Camera>().fieldOfView -= Input.mouseScrollDelta.y * perspectiveScrollSpeed;

			GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, 15f, 80.1f);
		}
		

	}
	
	
	
}
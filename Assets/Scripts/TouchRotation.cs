using UnityEngine;
using System.Collections;

public class TouchRotation : MonoBehaviour {
	
	private Touch touchLast;
	public Transform eagle;
	
	// Use this for initialization
	void Start () {
		transform.LookAt(eagle.transform);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount==1)
		for (int i = 0; i < Input.touchCount; ++i) {
			Touch touch = Input.GetTouch (i);
			if (touch.phase == TouchPhase.Moved) {
				if (touch.position.x != touchLast.position.x) {
					if((touchLast.position.x - touch.position.x)<80 && (touchLast.position.x - touch.position.x)>-80){
						//transform.Rotate (0, (touchLast.position.x - touch.position.x)/7, 0);

						transform.RotateAround(eagle.position, Vector3.up, -(touchLast.position.x - touch.position.x)/7);
						transform.LookAt(eagle.transform);
					}
				}
				touchLast = touch;
			}
		}
	}
}

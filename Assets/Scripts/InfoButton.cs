using UnityEngine;
using System.Collections;

public class InfoButton : MonoBehaviour {

	int fl;
	public Transform target;
	public Camera mainCamera;
	// Use this for initialization
	void Start () {
		mainCamera.cullingMask &=  ~(1 << LayerMask.NameToLayer("ButtonUpFloor"));
		mainCamera.cullingMask &=  ~(1 << LayerMask.NameToLayer("ButtonMidFloor"));
		mainCamera.cullingMask &=  ~(1 << LayerMask.NameToLayer("ButtonDownFloor"));
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
		fl = EagleControl.flag;
		if (fl == 1) {
			mainCamera.cullingMask |= 1 << LayerMask.NameToLayer ("ButtonUpFloor");
			mainCamera.cullingMask &= ~(1 << LayerMask.NameToLayer ("ButtonMidFloor"));
			mainCamera.cullingMask &= ~(1 << LayerMask.NameToLayer ("ButtonDownFloor"));
		} else if (fl == 2) {
			mainCamera.cullingMask |= 1 << LayerMask.NameToLayer ("ButtonMidFloor");
			mainCamera.cullingMask &= ~(1 << LayerMask.NameToLayer ("ButtonUpFloor"));
			mainCamera.cullingMask &= ~(1 << LayerMask.NameToLayer ("ButtonDownFloor"));
		} else if (fl == 3) {
			mainCamera.cullingMask |= 1 << LayerMask.NameToLayer ("ButtonDownFloor");
			mainCamera.cullingMask &= ~(1 << LayerMask.NameToLayer ("ButtonUpFloor"));
			mainCamera.cullingMask &= ~(1 << LayerMask.NameToLayer ("ButtonMidFloor"));
		}else {
			mainCamera.cullingMask &=  ~(1 << LayerMask.NameToLayer("ButtonUpFloor"));
			mainCamera.cullingMask &=  ~(1 << LayerMask.NameToLayer("ButtonMidFloor"));
			mainCamera.cullingMask &=  ~(1 << LayerMask.NameToLayer("ButtonDownFloor"));
		}



	
	}
}

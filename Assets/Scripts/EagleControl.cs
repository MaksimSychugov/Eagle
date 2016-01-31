using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EagleControl : MonoBehaviour {
	//public Button Button1;
	public static int flag;
	public GameObject roof;
	public GameObject up;
	public GameObject mid;

	Vector3 roofBeginPossition;
	Vector3 upBeginPossition;
	Vector3 midBeginPossition;

	Vector3 roofEndPossition;
	Vector3 upEndPossition;
	Vector3 midEndPossition;

	public Animator animBook;

	public Camera mainCamera;
	LayerMask layerWall;

	// Use this for initialization
	void Start () {
		roofBeginPossition = roof.transform.localPosition;
		upBeginPossition = up.transform.localPosition;
		midBeginPossition = mid.transform.localPosition;

		roofEndPossition = roofBeginPossition;
		upEndPossition = upBeginPossition;
		midEndPossition = midBeginPossition;

		roofEndPossition.y = 100;
		upEndPossition.y = 90;
		midEndPossition.y = 80;



	}

	public void ForButton1()
	{
		flag = 1;
	}
	public void ForButton2()
	{
		flag = 2;
	}
	public void ForButton3()
	{
		flag = 3;
	}

	public void ForButtonHome()
	{
		animBook.SetBool ("IsOpened", false);
		mainCamera.cullingMask |= 1 << LayerMask.NameToLayer("Walls");
		flag = 4;
	}

	public void ForButtonBook()
	{
		if (animBook.GetBool ("IsOpened")) {
			animBook.SetBool ("IsOpened", false);
		} else {
			animBook.SetBool ("IsOpened", true);
		}
	}
	public void ForButtonNoWall()
	{

		mainCamera.cullingMask ^= 1 << LayerMask.NameToLayer("Walls");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 1) {
			roof.transform.localPosition = Vector3.Lerp(roof.transform.localPosition, roofEndPossition, Time.deltaTime*4);
			up.transform.localPosition = Vector3.Lerp(up.transform.localPosition, upBeginPossition, Time.deltaTime*8);
			mid.transform.localPosition = Vector3.Lerp(mid.transform.localPosition, midBeginPossition, Time.deltaTime*8);
		}
		if (flag == 2) {
			roof.transform.localPosition = Vector3.Lerp(roof.transform.localPosition, roofEndPossition, Time.deltaTime*8);
			up.transform.localPosition = Vector3.Lerp(up.transform.localPosition, upEndPossition, Time.deltaTime*4);
			mid.transform.localPosition = Vector3.Lerp(mid.transform.localPosition, midBeginPossition, Time.deltaTime*8);
		}
		if (flag == 3) {
			roof.transform.localPosition = Vector3.Lerp(roof.transform.localPosition, roofEndPossition, Time.deltaTime*12);
			up.transform.localPosition = Vector3.Lerp(up.transform.localPosition, upEndPossition, Time.deltaTime*8);
			mid.transform.localPosition = Vector3.Lerp(mid.transform.localPosition, midEndPossition, Time.deltaTime*4);
		}
		if (flag == 4) {
			roof.transform.localPosition = Vector3.Lerp(roof.transform.localPosition, roofBeginPossition, Time.deltaTime*4);
			up.transform.localPosition = Vector3.Lerp(up.transform.localPosition, upBeginPossition, Time.deltaTime*8);
			mid.transform.localPosition = Vector3.Lerp(mid.transform.localPosition, midBeginPossition, Time.deltaTime*12);
		}


	
	}
}

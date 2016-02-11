using UnityEngine;
using System.Collections;
using Vuforia;

public class SetActiveButtons : MonoBehaviour {


	 GameObject[] InfoButtonsUp;
	 GameObject[] InfoButtonsMid;
	 GameObject[] InfoButtonsDown;
	// Use this for initialization
	void Start () {
		InfoButtonsUp = GameObject.FindGameObjectsWithTag("InfoButtonsUp");
		InfoButtonsMid = GameObject.FindGameObjectsWithTag ("InfoButtonsMid");
		InfoButtonsDown = GameObject.FindGameObjectsWithTag ("InfoButtonsDown");
		ShowGroupButtons (false, false, false);



	}

	void ShowInfoButtons(GameObject[] InfoButtons, bool isActive)
	{
		foreach (GameObject g in InfoButtons) 
		{
			g.SetActive(isActive);
		}
	}

	void ShowGroupButtons(bool isUp, bool isMid, bool isDown)
	{
		ShowInfoButtons (InfoButtonsUp, isUp);
		ShowInfoButtons (InfoButtonsMid, isMid);
		ShowInfoButtons (InfoButtonsDown, isDown);

	}

	// Update is called once per frame
	void Update () {
	if (Application.loadedLevelName == "Key") {
			if (EagleControl.flag == 1) {
				ShowGroupButtons (true, false, false);
			}
			if (EagleControl.flag == 2) {
				ShowGroupButtons (false, true, false);
			}
			if (EagleControl.flag == 3) {
				ShowGroupButtons (false, false, true);
			}
			if (EagleControl.flag == 4) {
				ShowGroupButtons (false, false, false);
			}
		}
		if (Application.loadedLevelName == "SceneAR" && DefaultTrackableEventHandler.isDetected == true) {
			if (EagleControl.flag == 1) {
				ShowGroupButtons (true, false, false);
			}
			if (EagleControl.flag == 2) {
				ShowGroupButtons (false, true, false);
			}
			if (EagleControl.flag == 3) {
				ShowGroupButtons (false, false, true);
			}
			if (EagleControl.flag == 4) {
				ShowGroupButtons (false, false, false);
			}
		}
		else if (Application.loadedLevelName == "SceneAR" && DefaultTrackableEventHandler.isDetected == false) {
			ShowGroupButtons (false, false, false);
		}
	
	}
}

using UnityEngine;
using System.Collections;
using Vuforia;



public class MarkerSearcher : MonoBehaviour {


	public GameObject imageBoader;
	float timer = 0.5f;
	bool timeChange = true;

	// Use this for initialization
	void Start () {
		
	}

	void ChangeSetActive() 
	{
		if (timer > 0.0f) { 
			timer -=Time.deltaTime;
		}
		
		if (timer < 0.0f && timeChange) { 
			imageBoader.SetActive(false);
			timer = 0.6f;
			timeChange = false;
		}
		
		if (timer < 0.0f && !timeChange) {
			imageBoader.SetActive(true);
			timer = 0.6f;
			timeChange = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!DefaultTrackableEventHandler.isDetected) {
			ChangeSetActive ();
		} else {
			imageBoader.SetActive(false);
		}
	
	}
}

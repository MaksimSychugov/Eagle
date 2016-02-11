using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextMenu : MonoBehaviour {

	public static int flag = 0;
	bool flagInfoActive = false;

	
	// Use this for initialization
	void Start () {
		
	}

	void EnableCanvas()
	{
		this.gameObject.SetActive (true);
	}
	void DisableCanvas()
	{
		this.gameObject.SetActive (false);
	}



	public void ForInfoButton(int f)
	{
		GetComponent<CanvasGroup>().alpha = 0;
		flag = f;
		flagInfoActive = true;
		EnableCanvas();
	}

	public void ForInfoButtonExit()
	{
		flagInfoActive = false;

	}
	
	IEnumerator Appear() {
		for (float f = 0f; f <= 1f; f += 0.02f) {
			GetComponent<CanvasGroup>().alpha = f;
			yield return null;
		}
	}
	IEnumerator Fade() {
		for (float f = 1f; f >= 0f; f -= 0.02f) {
			GetComponent<CanvasGroup>().alpha = f;

			yield return null;
		}
		DisableCanvas ();
	}
	
	void Update() {
		if (flagInfoActive == true) {
			StopCoroutine("Fade");
			StartCoroutine ("Appear");	
		}

		if (flagInfoActive == false) {
			StopCoroutine("Appear");
			StartCoroutine ("Fade");
		}
	}
}
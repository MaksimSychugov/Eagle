using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WriteText : MonoBehaviour {

	string msg1 ="Объект №1\n" +
		"Описание:\n" +
		"Левый";
	string msg2 ="Объект №2\n" +
		"Описание:\n" +
			"Правый";
	Text tx;
	// Use this for initialization
	void Start () {
		tx = GetComponent<Text> ();
	}
	/*
	public IEnumerator Write()
	{
		//yield return new WaitForSeconds (1.0f);
		for (int i = 0; i<= msg.Length; i++) {
			tx.text = msg.Substring(0,i);
			yield return null;
		}
	}
	*/
	// Update is called once per frame
	void Update () {

		switch (TextMenu.flag) {
			case 1: tx.text = msg1; break;
			case 2: tx.text = msg2; break;
		}
		/*if (TextMenu.flag == 1) {
			//tx.text = msg;
			StartCoroutine("Write");
		}
		if (TextMenu.flag == 2) {
			StopCoroutine("Write");
			tx.text = "";
		}*/
		
	}
}
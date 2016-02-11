using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WriteText : MonoBehaviour {

	string[] msg = {"Объект №1\n" +
		"Описание:\n" +
		"Левый белый куб на 3 этаже",
	   "Объект №2\n" +
		"Описание:\n" +
		"Правый белый куб на 3 этаже",
		"Объект №3\n" +
		"Описание:\n" +
		"Левый белый куб на 2 этаже",
		"Объект №4\n" +
		"Описание:\n" +
		"Правый белый куб на 1 этаже"	};
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


		tx.text = msg [TextMenu.flag];
		

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
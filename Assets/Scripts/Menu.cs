using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

 public void OpenARMode()
	{
		Application.LoadLevel("SceneAR");
	}
 public void OpenViewerMode()
	{
		Application.LoadLevel("Key");
	}
 public void Exit()
	{
		Application.Quit ();
	}
 public void OpenVK()
	{
		Application.OpenURL ("http://vk.com/");
	}
}

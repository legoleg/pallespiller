using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI ()
	{
		Rect playBtnRect = new Rect (Screen.width/2-100,Screen.height/2-100,200,200);
		if (GUI.Button(playBtnRect,"Play")) {
			Application.LoadLevel("fallingObjects");
		}
	}
}

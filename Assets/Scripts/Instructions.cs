using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {

	string instructions = 
		"Pack your Pills!\n" +
		"Use arrow keys to move the box.\n" +
		"Catch pills with the box.\n\n" +
		"<    >";

	static GameObject go;

	void Start ()
	{
		go = gameObject;
		Show ();
	}

	void Update () {
		guiText.text = instructions;
	}
	
	public static void Show ()
	{
		iTween.MoveFrom (go, iTween.Hash ("position", go.transform.position + (Vector3.up * 2), "easetype", iTween.EaseType.easeOutBack, "time", .25f));
	}
	
	public static void Hide ()
	{
		iTween.MoveTo (go, iTween.Hash ("position", go.transform.position + (Vector3.up * 2), "easetype", iTween.EaseType.easeInBack, "time", .25f));
	}
}

using UnityEngine;
using System.Collections;

public class LoadLevelButtonGUITxt : MonoBehaviour {

	static GameObject go;
	
	void Start ()
	{
		go = gameObject;
	}
	
	public static void Show ()
	{
		iTween.MoveTo (go, iTween.Hash ("position", new Vector3 (.5f, .7f, 0f), "easetype", iTween.EaseType.easeOutBack, "time", .25f));
	}
	
	public static void Hide ()
	{
		iTween.MoveTo (go, iTween.Hash ("position", new Vector3 (.5f, 1.7f, 0f), "easetype", iTween.EaseType.easeInBack, "time", .25f));
	}
}

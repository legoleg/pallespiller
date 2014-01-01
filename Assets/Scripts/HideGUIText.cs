using UnityEngine;
using System.Collections;

public class HideGUIText : MonoBehaviour {

	static GameObject go;
	
	void Start ()
	{
		go = gameObject;
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

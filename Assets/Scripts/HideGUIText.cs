using UnityEngine;
using System.Collections;

public class HideGUIText : MonoBehaviour {

	static GameObject go;
	
	void Start ()
	{
		go = gameObject;
	}
	
	public static void Show (float time)
	{
		iTween.MoveFrom (go, iTween.Hash ("position", go.transform.position + (Vector3.up * 2), "easetype", iTween.EaseType.easeOutBack, "time", time));
	}
	
	public static void Hide (float time)
	{
		iTween.MoveTo (go, iTween.Hash ("position", go.transform.position + (Vector3.up * 2), "easetype", iTween.EaseType.easeInBack, "time", time));
	}
}

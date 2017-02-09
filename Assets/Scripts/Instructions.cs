using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {

	string instructions = 
		"<   Pak Pillerne!   >\n" +
		"Flyt kassen med pilene.\n" +
		"Grib pillerne med kassen.\n\n";


	void Update () {
		GetComponent<GUIText>().text = instructions;
	}

//	static GameObject go;
//
//	void Start ()
//	{
//		go = gameObject;
//		Show ();
//	}
//
//	public static void Show ()
//	{
//		iTween.MoveFrom (go, iTween.Hash ("position", go.transform.position + (Vector3.up * 2), "easetype", iTween.EaseType.easeOutBack, "time", .25f));
//	}
//	
//	public static void Hide ()
//	{
//		iTween.MoveTo (go, iTween.Hash ("position", go.transform.position + (Vector3.up * 2), "easetype", iTween.EaseType.easeInBack, "time", .25f));
//	}
}

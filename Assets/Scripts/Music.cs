using UnityEngine;
using System.Collections;


[RequireComponent(typeof (AudioSource))]
public class Music : MonoBehaviour {

	public static GameObject go;

	void Start ()
	{
		go = gameObject;
		FadeIn (.5f);
	}

	public static void FadeIn (float time)
	{
		iTween.AudioTo (go, 1f, 1f, time);
		go.GetComponent<AudioSource>().Play ();
	}

	public static void FadeOut (float time)
	{
		iTween.AudioTo (go, 0f, 0f, time);
		//go.audio.Stop ();
	}
}

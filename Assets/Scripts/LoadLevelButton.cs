using UnityEngine;
using System.Collections;

public class LoadLevelButton : MonoBehaviour {

	public string levelToLoad;

	static GameObject go;
	
	void Start ()
	{
		go = gameObject;
	}
	
	public static void Show ()
	{
		LoadLevelButtonGUITxt.Show();
		iTween.MoveTo (go, iTween.Hash ("position", new Vector3 (0f, 1.5f, -8f), "easetype", iTween.EaseType.easeOutBack, "time", .25f));
	}
	
	public static void Hide ()
	{
		LoadLevelButtonGUITxt.Hide();
		iTween.MoveTo (go, iTween.Hash ("position", new Vector3 (0f, 3.5f, -8f), "easetype", iTween.EaseType.easeInBack, "time", .25f));
	}


	void OnMouseEnter ()
	{
		iTween.ScaleTo (gameObject, iTween.Hash("scale", Vector3.one * .7f, "time", .2f, "easetype", iTween.EaseType.easeInOutBack));
	}
	
	void OnMouseExit ()
	{
		iTween.ScaleTo (gameObject, iTween.Hash("scale", Vector3.one * .6f, "time", .2f, "easetype", iTween.EaseType.easeInOutBack));
	}
	
	IEnumerator OnMouseUpAsButton ()
	{
		//fade out
		Music.FadeOut(.5f);
		iTween.ScaleTo (gameObject, iTween.Hash("scale", Vector3.one * .6f, "time", .1f, "easetype", iTween.EaseType.easeInOutBack));
		yield return new WaitForSeconds (.1f);

		iTween.ScaleTo (gameObject, iTween.Hash("scale", Vector3.one * .7f, "time", .1f, "easetype", iTween.EaseType.easeInOutBack));
		yield return new WaitForSeconds (.1f);

		yield return new WaitForSeconds (.3f);
		Application.LoadLevel(levelToLoad);
	}
}

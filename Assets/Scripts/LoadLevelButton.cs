using UnityEngine;
using System.Collections;

public class LoadLevelButton : MonoBehaviour {

	public string levelToLoad;


	public void Show (float time)
	{
		iTween.MoveTo (gameObject, iTween.Hash ("position", new Vector3 (0f, 1.5f, -8f), "easetype", iTween.EaseType.easeOutBack, "time", time));
	}
	
	public void Hide (float time)
	{
		iTween.MoveTo (gameObject, iTween.Hash ("position", new Vector3 (0f, 3.5f, -8f), "easetype", iTween.EaseType.easeInBack, "time", time));
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

		Hide(.1f);
		yield return new WaitForSeconds (.3f);
		Application.LoadLevel(levelToLoad);
	}
}

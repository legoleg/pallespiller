using UnityEngine;
using System.Collections;

public class LoadLevelButton : MonoBehaviour {

	public string levelToLoad;

	void OnMouseDown()
	{
		Application.LoadLevel(levelToLoad);
	}
}

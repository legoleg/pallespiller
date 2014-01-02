using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour
{
	int currPos = 2;
	public GameObject[] spawns;
	public GameObject loadLvlBtn;

	void Start ()
	{
		spawns = GameObject.FindWithTag("GameController").GetComponent<GameController>().spawns;
	}

	void Update ()
	{
		// get input
		if (Input.GetKeyDown("left"))
		{
			MoveLeft();
		}
		else if (Input.GetKeyDown("right"))
		{
			MoveRight();
		}
	}

	void MoveLeft ()
	{
		//only move 
		if (currPos > 0) {
			currPos--;
			//do the movement
			Move ();
		}
	}

	void MoveRight ()
	{
		if (currPos < spawns.Length-1) {
			currPos++;
			//do the movement
			Move ();
		}
	}

	void Move ()
	{
		if (GameController.done) {
			return;
		}

		if (!GameController.playing) {
			HideGUIText.Hide(.1f);
			loadLvlBtn.GetComponent<LoadLevelButton>().Hide(.1f);
			GameController.playing = true;
		}

		iTween.MoveTo (this.gameObject, iTween.Hash (
			"position", new Vector3 (spawns [currPos].transform.position.x, -1f, 0f), 
			"easetype", iTween.EaseType.spring, 
			"time", .4f));
	}
}

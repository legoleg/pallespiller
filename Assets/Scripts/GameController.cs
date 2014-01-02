using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	// keep track og the amount of objects caught
	public float timeLimit = 120f;

	public static int bluePoints = 0;
	public static int redPoints = 0;
	public static int bluePointsLost = 0;
	public static int redPointsLost = 0;
	public static bool playing = false;
	public static bool done = false;

	public GameObject blueTxt,redTxt,blueTxtLost,redTxtLost;
	public GameObject[] objectsToSpawn;
	public GameObject[] spawns;
	public float spawnRate = .5f;

	public AudioClip inGame, postGame;
	public GameObject loadLvlBtn;


	void Update ()
	{
		redTxt.guiText.text = redPoints.ToString();
		blueTxt.guiText.text = bluePoints.ToString();
		redTxtLost.guiText.text = redPointsLost.ToString();
		blueTxtLost.guiText.text = bluePointsLost.ToString();
	}

	void Start ()
	{
		bluePoints = 0;
		redPoints = 0;
		bluePointsLost = 0;
		redPointsLost = 0;
		playing = false;
		done = false;

		StartCoroutine (SpawnRoutine());
		StartCoroutine (GameTimer());
	}

	IEnumerator SpawnRoutine ()
	{
		//instantiate a random object at a random spawnpoint
		GameObject spawnedObj = (GameObject)Instantiate (objectsToSpawn[Random.Range(0,objectsToSpawn.Length)], 
		             spawns[Random.Range(0,spawns.Length)].transform.position, 
		             Random.rotation);
		spawnedObj.rigidbody.AddTorque(Random.insideUnitSphere, ForceMode.Impulse);

		//wait and loop
		yield return new WaitForSeconds (spawnRate);
		StartCoroutine (SpawnRoutine());
	}

	IEnumerator GameTimer ()
	{
		yield return new WaitForSeconds (timeLimit);

		playing = false;
		done = true;
		iTween.MoveTo (GameObject.FindGameObjectWithTag("Player"), iTween.Hash (
			"position", new Vector3 (0, 0f, -7f), 
			"easetype", iTween.EaseType.easeInOutBack, 
			"time", 1f));
		Music.FadeOut(.9f);
		yield return new WaitForSeconds (1f);

		Music.go.audio.clip = postGame;
		Music.FadeIn(.5f);
		loadLvlBtn.GetComponent<LoadLevelButton>().Show(.1f);
		yield return new WaitForSeconds (postGame.length + .5f);

		// sum points
		Application.LoadLevel ("mainMenu");
	}
}

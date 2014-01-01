using UnityEngine;
using System.Collections;

public class FallingObject : MonoBehaviour
{
	public bool blue = true;

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			if (blue)
			{
				GameController.bluePoints++;
				// scale points
				// sound
			}
			else
			{
				GameController.redPoints++;
				// scale points
				// sound
			}
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter (Collider collider)
	{
		if (GameController.playing && collider.gameObject.CompareTag ("ZoneLosePill"))
		{
			if (blue)
			{
				GameController.bluePointsLost++;
				// scale points
				// sound
			}
			else
			{
				GameController.redPointsLost++;
				// scale points
				// sound
			}
		}
	}
}

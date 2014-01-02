using UnityEngine;
using System.Collections;

[RequireComponent (typeof (GUIText))]
public class ObjectLabel : MonoBehaviour {
	
	public Transform target;  // Object that this label should follow
	public Vector3 offset = Vector3.zero;    // Units in world space to offset; 1 unit above object by default

	
	void Update()
	{
		transform.position = Camera.main.WorldToViewportPoint(target.position + offset);
	}
}

using UnityEngine;
using System.Collections;

public class CameraPlayer1 : MonoBehaviour {

	public GameObject move;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - move.transform.position;
	}

	// LateUpdate is run after all items have been processed in update
	void Update () {
		if (move) {
			transform.position = move.transform.position + offset;
		}

	}
}

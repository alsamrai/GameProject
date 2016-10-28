using UnityEngine;
using System.Collections;

public class asteroidMovement : MonoBehaviour {

	

	// Enemy movement method 
	void Update () 
	{
		transform.position = new Vector3 (Mathf.PingPong (Time.time, 4),transform.position.y, 
			transform.position.z );
	}
}

using UnityEngine;
using System.Collections;

public class AsteriodRotation : MonoBehaviour {

	
	// Rotate Enemy method
	void Update () {
		transform.Rotate(0, 90 * Time.deltaTime, 0);
	}
}

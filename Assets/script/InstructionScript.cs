using UnityEngine;
using System.Collections;

public class InstructionScript : MonoBehaviour {

	// Use this for initialization
	public float time = 5; //Seconds to read the text

	void Start ()
	{     
		Destroy(gameObject, time);
	}
}

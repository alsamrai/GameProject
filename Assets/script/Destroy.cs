 using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour {

	private player gameController;

	//once the ball collides with the asteroid the game will rest
	void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene ("GameProject");
	}	
}

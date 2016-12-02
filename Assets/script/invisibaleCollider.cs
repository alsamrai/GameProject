using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class invisibaleCollider : MonoBehaviour {

	//once the ball touch this object it will rest the game 
	private player gameController;

	void OnTriggerEnter(Collider other)
	{
		
			SceneManager.LoadScene ("GameProject");
	}	
}

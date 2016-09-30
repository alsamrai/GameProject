using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class invisibaleCollider : MonoBehaviour {

	//public GameObject explosion;
	private player gameController;

	void OnTriggerEnter(Collider other)
	{
			SceneManager.LoadScene ("GameProject");
	}	
}

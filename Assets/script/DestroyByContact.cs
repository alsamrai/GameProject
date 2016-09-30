using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	//public GameObject explosion;

	void OnTriggerEnter(Collider other) 
	{
		//Destroy(other.gameObject);
		if (other.tag == "player") 
		{
			Destroy (gameObject);
		}
	}
}
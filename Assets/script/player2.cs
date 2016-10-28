using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class player2 : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text WinText;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		WinText.text = "";
		count = 0;
		SetCountText ();
	}
	/*
	 * Move Player2 method with i,j,l,k keys control  
	 */
	void FixedUpdate ()
	{
		float hor = 0;
		float ver = 0;
		if (Input.GetKey ("j"))
			hor = -1;
		if (Input.GetKey ("l"))
			hor = 1;
		if (Input.GetKey ("i"))
			ver = 1;
		if (Input.GetKey ("k"))
			ver = -1;
		Vector3 vel = new Vector3 (hor, 0, ver);
		rb.position+= vel * speed*Time.deltaTime;
	}

	/* 
	 *  Ontrigger method is using collider object as parameter... 
	 * it collides either pick up an object and count your score 
	 * or end point an object
	*/
	void OnTriggerEnter ( Collider other) 
	{
		if (other.gameObject.CompareTag("Win"))
		{
			other.gameObject.SetActive (false);
			WinText.text = "You Win!";
		}
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}
		
	void SetCountText()
	{
		countText.text = "Coint: " + count.ToString ();			
	}
		
} 
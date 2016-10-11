using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class player : MonoBehaviour {

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
	 * Move Player method  
	 */
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
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
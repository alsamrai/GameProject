using UnityEngine;
using System.Collections;

public class CamearaSwitch : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public bool camera1Active;

	// switch camera method between player1 and player2 
	void FixedUpdate(){
		if (Input.GetKey (KeyCode.X)) {
			if (camera1Active) {
				player1.SetActive (false);
				player2.SetActive (true);
				camera1Active = false;
			} else {
				player1.SetActive (true);
				player2.SetActive (false);
				camera1Active = true;
			}
		}
	}
}

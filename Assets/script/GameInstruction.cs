using UnityEngine;
using System.Collections;

public class GameInstruction : MonoBehaviour {


	private string gameInfo;
	private bool show;
	// Use this for initialization
	void Start () {
		gameInfo = "";
		gameInfo += "- W,S,A,D keys move player one ";
		gameInfo += "- I.K.J.L keys move player two /n ";
		gameInfo += "- 'x' key switch between players camera! ";
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGuI ()
	{
		if (GUI.Button (new Rect (Screen.width - 40, 5, 35, 35), "!")) {
			show = !show;
		}
		if (show)
			GUI.Label (new Rect (Screen.width - 310, 35, 300, 500), gameInfo);
	}
}

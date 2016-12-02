 using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour {

	private player gameController;
	public  GUIText restartText;
	public GUIText gameOverText;

	private bool gameOver;
	private bool restart;

	void Start(){
		gameOver = false;
		restart = false;
		gameOverText.text = "";
		restartText.text = "";
	}
	//once the ball collides with the asteroid the game will rest
	void OnTriggerEnter(Collider other)
	{
		GameOver ();
		if (gameOver) {
			Destroy (other.gameObject);
			Destroy (gameObject);
			System.Threading.Thread.Sleep(3000);
			Restart ();
			if (Input.GetKey ("r")){
				SceneManager.LoadScene ("GameProject");
			}
		}
	}	

	public void GameOver(){
		gameOverText.text = "Game Over! ";
		gameOver = true;
	}
	public void Restart(){
		restartText.text = "Press 'R' to Restart The Game ";
		restart = true; 
	}
}

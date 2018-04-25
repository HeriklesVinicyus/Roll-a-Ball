using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public int score;
	public  Text scoreText;
	public  Text winText;
	public float speed;
	private Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		updateScore ();
		winText.text = "";
	}
		
	// FixedUpdate é chamado quando ocorre um novo calculo na física
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");	

		Vector3 moviment = new Vector3 (moveHorizontal, 0f, moveVertical);

		rb.AddForce (moviment * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			score++;
			updateScore ();
		}
	}

	void updateScore(){
		scoreText.text= "Score: "+this.score;
		if(score>=8){
			winText.text = "You Win!";
		}
	}

}
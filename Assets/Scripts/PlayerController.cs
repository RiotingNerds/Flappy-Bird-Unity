using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0,300);
	public int score = 0;

	public GUIText scoreText;

	// Use this for initialization
	void Start () {
	
	}

	public float getXValue() {
		return transform.position.x;
	}

	public void incScore() {
		score++;
		scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("space") || (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended)) {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}
	// Die by collision
	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
			
	}

	void OnTriggerEnter2D (Collider2D other) {
		incScore();
	}
	
	void Die()
	{
		Application.LoadLevel("end");
	}
}
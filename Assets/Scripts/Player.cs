using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0,300);
	public int score = 0;

	// Use this for initialization
	void Start () {
	
	}

	public float getXValue() {
		return transform.position.x;
	}

	public void incScore(GameObject g) {
		Destroy(g,5f);
		score++;
	}

	void OnGUI () 
	{
		GUI.color = Color.black;
		GUILayout.Label(" Score: " + score.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("space")) {
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
	
	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
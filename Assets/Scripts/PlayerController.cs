using UnityEngine;
using System.Collections;
using System;
using System.Net;

public class PlayerController : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0,300);

	public GUIText scoreText;

	public AudioSource crashSound;
	
	void Start() {
		string name = Dns.GetHostName();
		ScoreChart.Score = 0;
		try{
			IPAddress[] addrs = Dns.GetHostEntry(name).AddressList;
			foreach(IPAddress addr in addrs) 
				Debug.Log(String.Format("{0}/{1}",name,addr).ToString());
		}catch(Exception e){
			Debug.Log(e.Message);
		}
		scoreText.fontSize = Mathf.Min(Screen.height,Screen.width)/18;

	}


	public float getXValue() {
		return transform.position.x;
	}

	public void incScore() {
		ScoreChart.Score += 1;
		scoreText.text = "Score: " + ScoreChart.Score;
	}

	void jumpPlayer() {
		rigidbody2D.velocity = Vector2.zero;
		rigidbody2D.AddForce(jumpForce);
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.LoadLevel("start");
		if(Input.GetKeyUp("space") || (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended)) {
			jumpPlayer();
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
		crashSound.Play ();
		StartCoroutine(DieWait());
			
	}

	void OnTriggerEnter2D (Collider2D other) {
		incScore();
	}

	IEnumerator DieWait() {
		yield return new WaitForSeconds (0.5f);
		Die ();
	}
	
	void Die()
	{
		Application.LoadLevel("end");
	}
}
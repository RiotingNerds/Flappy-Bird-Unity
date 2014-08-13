using UnityEngine;
using System.Collections;

public class Rocks : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4, 0);
	public float range = 4;
	private Player p ;
	private bool updated = false;
	Vector2 screenPosition;
	
	// Use this for initialization
	void Start()
	{
		rigidbody2D.velocity = velocity;
		screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		Vector2 v = new Vector2 (transform.position.x, transform.position.y);
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
		GameObject go = GameObject.Find ("player");
		p = go.GetComponent<Player> ();

	}

	float getPosX() {
		return transform.position.x + 12.10f;
	}

	// Update is called once per frame
	void Update () {
		if (!updated && getPosX() < p.getXValue ()) {

			p.incScore(this.gameObject);
			updated = true;
		}
	}
}

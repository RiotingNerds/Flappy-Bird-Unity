using UnityEngine;
using System.Collections;

public class RocksController : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4, 0);
	public float rangeY = 4;
	public float rangeX = 2;
	Vector2 screenPosition;
	
	// Use this for initialization
	void Start()
	{
		rigidbody2D.velocity = velocity;
		transform.position = new Vector3(transform.position.x - rangeX * Random.value, transform.position.y - rangeY * Random.value, transform.position.z);


	}

	float getPosX() {
		return transform.position.x + 12.10f;
	}

	// Update is called once per frame
	void Update () {

	}
}

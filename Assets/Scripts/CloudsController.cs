using UnityEngine;
using System.Collections;

public class CloudsController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 velocity = new Vector2(Random.Range(-4.0F, 0F), 0);
		rigidbody2D.velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - 2 * Random.value, transform.position.z);
	}
}

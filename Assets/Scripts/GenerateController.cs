using UnityEngine;
using System.Collections;

public class GenerateController : MonoBehaviour {

	public GameObject Rocks;

	public GameObject[] Clouds;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("createRock", 1f, 1.5f);
		InvokeRepeating ("createCloud", 0.5f, 1.5f);
	}

	void createCloud() {
		int random = Random.Range (0, Clouds.Length - 1);
		Object createdCloud = Instantiate (Clouds[random]);
		DestroyObject (createdCloud,10f);

	}

	void createRock() {
		Object createdRocks = Instantiate (Rocks);
		DestroyObject (createdRocks, 10f);
	}
}

using UnityEngine;
using System.Collections;

public class GenerateController : MonoBehaviour {

	public GameObject Rocks;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("createRock", 1f, 1.5f);
	}

	void createRock() {
		Object createdRocks = Instantiate (Rocks);
		DestroyObject (createdRocks, 10f);
	}
}

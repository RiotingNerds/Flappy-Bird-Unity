using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject Rocks;
	public int score=0;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("createRock", 1f, 1.5f);
	}

	void createRock() {
		Instantiate (Rocks);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}

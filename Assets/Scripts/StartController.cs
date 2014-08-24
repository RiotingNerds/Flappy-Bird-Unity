using UnityEngine;
using System.Collections;

public class StartController : MonoBehaviour {

	void Update () {
		if(Input.GetKeyUp("space") || (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended)) {
			Application.LoadLevel("play");
		}
	}
}

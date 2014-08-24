using UnityEngine;
using System.Collections;

public class EndController : MonoBehaviour {

	public int score;

	void Update () {
		if(Input.GetKeyUp("space") || (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended)) {
			Application.LoadLevel("start");
		}
	}
}

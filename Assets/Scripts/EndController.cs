using UnityEngine;
using System.Collections;

public class EndController : MonoBehaviour {

	public int score;

	void Start() {
		GUIText myText = GameObject.Find ("Title").guiText;
		GUIText MyInfo = GameObject.Find ("Final Score").guiText;
		myText.fontSize = Mathf.Min(Screen.height,Screen.width)/15;
		MyInfo.fontSize = Mathf.Min(Screen.height,Screen.width)/25;

		MyInfo.text = "Your Score: " + ScoreChart.Score;
	}

	void Update () {
		if(Input.GetKeyUp("space") || (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetKeyDown(KeyCode.Escape)) {
			Application.LoadLevel("start");
		}
	}
}

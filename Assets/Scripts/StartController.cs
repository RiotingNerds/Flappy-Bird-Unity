using UnityEngine;
using System.Collections;

public class StartController : MonoBehaviour {

	void Start() {
		GUIText myText = GameObject.Find ("Title").guiText;
		GUIText MyInfo = GameObject.Find ("Info").guiText;
		Debug.Log ("height:"+Screen.height+"width:"+Screen.width);
		myText.fontSize = Mathf.Min(Screen.height,Screen.width)/15;
		MyInfo.fontSize = Mathf.Min(Screen.height,Screen.width)/25;
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 
		if(Input.GetKeyUp("space") || (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended)) {
			Application.LoadLevel("play");
		}
	}
}

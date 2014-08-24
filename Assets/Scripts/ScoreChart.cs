using UnityEngine;
using System.Collections;

public class ScoreChart : MonoBehaviour {

	private static int _score = 0;

	public static int Score {
				get {
			return _score;
				}
				set {
			_score = value;
				}
	}
}

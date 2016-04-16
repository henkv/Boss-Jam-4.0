using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoveTextBehaviour : MonoBehaviour {
	public GameObject scoreKeeper;

	private Text text;
	private ScoreKeeperBehaviour scoreKeeperBehaviour;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		scoreKeeperBehaviour = scoreKeeper.GetComponent<ScoreKeeperBehaviour> ();
	}
	
	// Update is called once per frame
	void Update () {

		text.text = "" + Mathf.CeilToInt (scoreKeeperBehaviour.loveLevel * 100.0f);
	
	}
}

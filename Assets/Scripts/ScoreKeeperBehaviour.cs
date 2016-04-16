using UnityEngine;
using System.Collections;

public class ScoreKeeperBehaviour : MonoBehaviour {
	public GameObject player;
	public float loveLevel;

	private float runTime;
	private float score;

	private PairBehaviour pairBehaviour;


	// Use this for initialization
	void Start () {
		pairBehaviour = player.GetComponent<PairBehaviour> ();
		score = 0;
		runTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (pairBehaviour.inLove) {
			score += Time.deltaTime;
		}

		runTime += Time.deltaTime;
		loveLevel = score / runTime;

	}
}

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
		score = 20;
		runTime = 20;
		loveLevel = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (!pairBehaviour.inLove) {
			runTime -= Time.deltaTime;
		}

		loveLevel = runTime / score;

	}
}

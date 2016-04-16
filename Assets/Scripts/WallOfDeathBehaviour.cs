using UnityEngine;
using System.Collections;

public class WallOfDeathBehaviour : MonoBehaviour {
	public GameObject scoreKeeper;

	private ScoreKeeperBehaviour skb;
	// Use this for initialization
	void Start () {
		skb = scoreKeeper.GetComponent<ScoreKeeperBehaviour> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (skb.loveLevel < 0) 
		{
			Loose ();
		}
	}

	void Loose()
	{
		Application.LoadLevel (1);

	}

	void OnTriggerEnter2D(Collider2D hit)
	{
		Debug.Log (hit.name);
		Loose ();
	}
}

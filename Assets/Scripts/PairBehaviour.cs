using UnityEngine;
using System.Collections;

public class PairBehaviour : MonoBehaviour {
	public GameObject significantOther;

	private ParticleSystem particleSystem;
	private bool inLove;

	// Use this for initialization
	void Start () {
		particleSystem = GetComponent<ParticleSystem> ();
		inLove = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 heading = significantOther.transform.position - transform.position;
		RaycastHit2D hit = Physics2D.Raycast (transform.position, heading);

		if (hit != null) {
			inLove = hit.collider.gameObject == significantOther;
		}

		if (inLove) {
			if (!particleSystem.isPlaying)
				particleSystem.Play ();

		} else {
			if (particleSystem.isPlaying)
				particleSystem.Stop ();
		}
	}
}

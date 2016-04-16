using UnityEngine;
using System.Collections;

public class FanBehaviour : MonoBehaviour {
	public float fanceForce;
	public float fanDistance;
	public bool active;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (active) {
			RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.up, fanDistance);

			if (hit.collider != null) {
				if (hit.collider.gameObject.tag == "Player") {

					hit.collider.gameObject.GetComponent<PlayerBehaviour> ();
					hit.rigidbody.AddForce (Vector2.up * fanceForce * (fanDistance - hit.distance));
				}			
			}
		}
	}
}

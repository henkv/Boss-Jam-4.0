using UnityEngine;
using System.Collections;

public class TileBehaviour : MonoBehaviour {
	public float xMin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < xMin) {
			Object.Destroy (gameObject);		
		}
	}
}

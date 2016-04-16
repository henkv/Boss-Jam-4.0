using UnityEngine;
using System.Collections;

public class WallOfDeathBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		Object.Destroy (collision.gameObject);
	}
}

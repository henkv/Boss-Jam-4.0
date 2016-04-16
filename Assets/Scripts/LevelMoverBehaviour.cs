using UnityEngine;
using System.Collections;

public class LevelMoverBehaviour : MonoBehaviour {
	public float levelSpeed;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		pos = transform.position;
		pos.x += levelSpeed * Time.deltaTime;
		transform.position = pos;
	}
}

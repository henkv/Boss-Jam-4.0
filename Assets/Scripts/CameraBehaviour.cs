using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraBehaviour : MonoBehaviour {
	public List<GameObject> players;
	public Vector3 center;
	public float cameraSpeed;

	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{
		center = Vector2.zero;
		center.z = -10;

		foreach (GameObject player in players) 
		{
			center.x += player.transform.position.x;
			center.y += player.transform.position.y;
		}

		center.x /= (float)players.Count;
		center.y /= (float)players.Count;

		transform.position = Vector3.Lerp (transform.position, center, cameraSpeed);
	}
}

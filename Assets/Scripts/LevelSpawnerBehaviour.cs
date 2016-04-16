using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelSpawnerBehaviour : MonoBehaviour {
	public List<GameObject> tiles;
	public float tileMoveSpeed;
	public int tileWidth;
	public float minX;

	public float tileDelta;
	private Quaternion qZero;
	private Vector2 childPos;

	// Use this for initialization
	void Start () {
		SpawnTile ();

	}

	// Update is called once per frame
	void Update () {
		foreach (Transform child in transform)
		{
			childPos = child.position;
			childPos.x -= tileMoveSpeed * Time.deltaTime;
			child.position = childPos;

			if (childPos.x < minX)
				Object.Destroy (child.gameObject);
		}

		tileDelta += tileMoveSpeed * Time.deltaTime;

		if (tileDelta >= 7f) 
		{
			SpawnTile ();
			tileDelta -= 7f;
		}
	}

	void SpawnTile()
	{
		GameObject tile = Instantiate(
			tiles[Random.Range(0, tiles.Count - 1)], 
			transform.position, 
			qZero
		) as GameObject;

		tile.transform.parent = transform;
	}

}

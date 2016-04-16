using UnityEngine;
using System.Collections;

public class LevelSpawnerBehaviour : MonoBehaviour {
	public GameObject grassTileNormal;
	public float tileMoveSpeed;
	public int tileWidth;

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
		}

		tileDelta += tileMoveSpeed * Time.deltaTime;

		if (tileDelta >= 0.9f) 
		{
			SpawnTile ();
			tileDelta -= 0.9f;
		}
	}

	void SpawnTile()
	{
		Vector3 spawnPos = new Vector3(0, 0, 0);
		GameObject tile = Instantiate(grassTileNormal, transform.position, qZero) as GameObject;
		tile.transform.parent = transform;
	}

}

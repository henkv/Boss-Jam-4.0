using UnityEngine;
using System.Collections;

public class GoalBehaviour : MonoBehaviour {
	public GameObject winner;
	public bool winning;

	// Use this for initialization
	void Start () {
		winning = false;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject == winner) 
		{
			winning = true;
		}
	}

	void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject == winner) 
		{
			winning = false;
		}
	}
}

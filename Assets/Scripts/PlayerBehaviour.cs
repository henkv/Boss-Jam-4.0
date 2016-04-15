using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	public KeyCode jumpKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	public float jumpForce;
	public float horizontalFoce;

	float airTime;
	Rigidbody2D rigidBody;
	bool inAir;


	// Use this for initialization
	void Start () 
	{
		rigidBody = GetComponent<Rigidbody2D> ();
		inAir = false;
		airTime = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.down);

		if (hit != null) 
		{
			Debug.Log (hit.fraction);
			if (hit.fraction < 0.4) 
			{
				inAir = false;
				airTime = 0;
			}
		}

		if (inAir)
		{
			airTime += Time.deltaTime;
		}

	}

	void FixedUpdate()
	{
		if (Input.GetKey(jumpKey) && airTime < 0.2)
		{
			inAir = true;
			rigidBody.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
		}

		if (Input.GetKey(leftKey))
		{

			rigidBody.AddForce (Vector2.left * horizontalFoce, ForceMode2D.Force);

		}

		if (Input.GetKey(rightKey))
		{
			rigidBody.AddForce (Vector2.right * horizontalFoce, ForceMode2D.Force);
		}


	}
}

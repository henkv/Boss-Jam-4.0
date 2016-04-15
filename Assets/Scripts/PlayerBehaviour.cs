using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	public KeyCode jumpKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	public float jumpForce;
	public float jumpOffset;
	public float horizontalFoce;

	float airTime;
	Rigidbody2D rigidBody;
	bool inAir;
	bool jumpKeyDown;


	// Use this for initialization
	void Start () 
	{
		rigidBody = GetComponent<Rigidbody2D> ();
		inAir = false;
		airTime = 0;
		jumpKeyDown = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (inAir) {
			RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.down);

			if (hit != null) {
				Debug.Log (hit.fraction);
				if (hit.fraction < 0.18) {
					inAir = false;
				}
			}
		}


	}

	void FixedUpdate()
	{
		if (Input.GetKeyDown(jumpKey) && !inAir)
		{
			jumpKeyDown = true;
			inAir = true;
			Vector3 playerPos = transform.position;
			playerPos.y += jumpOffset;
			transform.position = playerPos;
			rigidBody.AddForce (Vector2.up * jumpForce, ForceMode2D.Force);
		}

		if (Input.GetKey(leftKey))
		{

			rigidBody.AddForce (Vector2.left * horizontalFoce, ForceMode2D.Impulse);

		}

		if (Input.GetKey(rightKey))
		{
			rigidBody.AddForce (Vector2.right * horizontalFoce, ForceMode2D.Impulse);
		}


	}
}

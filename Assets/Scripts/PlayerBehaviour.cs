using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	public KeyCode jumpKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	public float jumpForce;
	public float jumpOffset;
	public float horizontalFoce;

	Rigidbody2D rigidBody;
	SpriteRenderer spriteRenderer;
    Animator animator;

	bool inAir;
	bool jumpKeyDown;
	bool lookingRight;


	// Use this for initialization
	void Start () 
	{
		rigidBody = GetComponent<Rigidbody2D> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
        animator = GetComponent<Animator>();

        inAir = false;
		jumpKeyDown = false;
		lookingRight = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (inAir) {
			RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.down);

			if (hit != null) {
				//Debug.Log (hit.fraction);
				if (hit.fraction < 0.2) 
				{
					inAir = false;
                    animator.SetBool("inAir", false);
                }
			}
		}

        if (Input.GetKey(leftKey) || Input.GetKey(rightKey))
        {
            animator.SetBool("isMoving", true);
        }

        else
        {
            animator.SetBool("isMoving", false);
        }



    }

	void FixedUpdate()
	{
		if (Input.GetKeyDown(jumpKey) && !inAir)
		{
			jumpKeyDown = true;
			inAir = true;
            animator.SetBool("inAir", true);
			Vector3 playerPos = transform.position;
			playerPos.y += jumpOffset;
			transform.position = playerPos;
			rigidBody.AddForce (Vector2.up * jumpForce, ForceMode2D.Force);
		}

		if (Input.GetKey(leftKey))
		{
			rigidBody.AddForce (Vector2.left * horizontalFoce, ForceMode2D.Impulse);

			if (lookingRight) 
			{
				lookingRight = false;
				spriteRenderer.flipX = true;
            }
		}

		if (Input.GetKey(rightKey))
		{
			rigidBody.AddForce (Vector2.right * horizontalFoce, ForceMode2D.Impulse);

			if (!lookingRight) 
			{
				lookingRight = true;
				spriteRenderer.flipX = false;
			}
		}
	}
}

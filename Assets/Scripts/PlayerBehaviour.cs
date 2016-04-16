using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	public KeyCode jumpKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	public float jumpForce;
	public float jumpOffset;
	public float horizontalFoce;
	public float airMultiplier;

	private Rigidbody2D rigidBody;
	private SpriteRenderer spriteRenderer;
	private Animator animator;

	bool inAir;


	// Use this for initialization
	void Start () 
	{
		rigidBody = GetComponent<Rigidbody2D> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
        animator = GetComponent<Animator>();

		inAir = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.down);

		if (hit.collider != null && hit.fraction < 0.5) {
			inAir = false;
		} else {
			inAir = true;
		}

		animator.SetBool ("inAir", inAir);


        if(Input.GetKey(leftKey) || Input.GetKey(rightKey))
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
			inAir = true;
            animator.SetBool("inAir", true);

            Vector3 playerPos = transform.position;
			playerPos.y += jumpOffset;
			transform.position = playerPos;
			rigidBody.AddForce (Vector2.up * jumpForce, ForceMode2D.Force);
		}

		if (Input.GetKey(leftKey))
		{
			rigidBody.AddForce (Vector2.left * horizontalFoce * (inAir ? airMultiplier : 1.0f), ForceMode2D.Force);

			if (!spriteRenderer.flipX) 
			{
				spriteRenderer.flipX = true;
			}
		}

		if (Input.GetKey(rightKey))
		{
			rigidBody.AddForce (Vector2.right * horizontalFoce * (inAir ? airMultiplier : 1.0f), ForceMode2D.Force);

			if (spriteRenderer.flipX) 
			{
				spriteRenderer.flipX = false;
			}
		}
	}
}

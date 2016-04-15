using UnityEngine;
using System.Collections;

public class LeekBehaviour : MonoBehaviour
{
    public bool leekActivated;
    public float fallLength;
	private float startPos;
    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start ()
    {
		rigidBody = GetComponent<Rigidbody2D> ();
		rigidBody.isKinematic = true;

        leekActivated = false;
        startPos = transform.position.y;
        fallLength = 0.8f;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (leekActivated && transform.position.y >= startPos - fallLength)
        {
            rigidBody.isKinematic = false;
        }

        else if (transform.position.y <= startPos - fallLength)
        {
            rigidBody.isKinematic = true;
        }
	}

    public void trigger()
    {
        leekActivated = true;
    }
}

using UnityEngine;
using System.Collections;

public class DishRackBehaviour : MonoBehaviour
{
    public bool rackActivated;
    private Rigidbody2D rigidbody;
    private float startPos;
    public float distance;


	// Use this for initialization
	void Start ()
    {
        rackActivated = false;
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.isKinematic = true;

        startPos = transform.position.x;
        distance = 0.3f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (rackActivated)
        {
            rigidbody.isKinematic = false;
            rigidbody.AddForce(new Vector2(-100, 0));
            rackActivated = false;
        }

        if (transform.position.x < startPos - distance)
        {
            rigidbody.isKinematic = true;
        }
    }

    public void trigger()
    {
        rackActivated = true;
    }
}

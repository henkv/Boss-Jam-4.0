using UnityEngine;
using System.Collections;

public class PotBehaviour : MonoBehaviour
{
    public bool potActivated;
    Rigidbody2D rigidbody;


	// Use this for initialization
	void Start ()
    {
        potActivated = false;
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (potActivated)
        {
            rigidbody.isKinematic = false;
            rigidbody.AddTorque(-133);
            potActivated = false;
        }
	}

    public void trigger()
    {
        potActivated = true;
    }
}

using UnityEngine;
using System.Collections;

public class PlateBehaviour : MonoBehaviour
{
    public bool plateActivated;
    private Rigidbody2D rigidbody;


	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (plateActivated)
        {
            rigidbody.isKinematic = false;
            plateActivated = false;
        }
	}
}

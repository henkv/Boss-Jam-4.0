﻿using UnityEngine;
using System.Collections;

public class DolphinFly : MonoBehaviour {
    private Vector3 startPos;
	private Vector3 orignialStartPos;
    public float high;
    private Vector3 endPos;
    public float speed;
    private bool active;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
        orignialStartPos = transform.position;
        endPos = startPos;
        endPos.y += high;

	}
	
	// Update is called once per frame
	void Update ()
    {
		startPos = transform.position;
		startPos.y = orignialStartPos.y;
		endPos = startPos;
		endPos.y += high;

        if(active)
        {
            transform.position = Vector3.Lerp(transform.position, endPos, speed);
            if(transform.position == endPos)
            {
                active = false;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, startPos, speed);
        }
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log(coll.gameObject.tag);
        if (coll.gameObject.tag == "Player")
        {
            active = true;
        }
    }
}

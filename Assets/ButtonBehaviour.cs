using UnityEngine;
using System.Collections;

public class ButtonBehaviour : MonoBehaviour {
	public Color activeColor;
	public bool active;

	private Color standardColor;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () 
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		standardColor = spriteRenderer.color;
		active = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	void OnTriggerEnter2D(Collider2D collision)
	{
		spriteRenderer.color = activeColor;
		active = true;
	}

	void OnTriggerExit2D(Collider2D collision)
	{
		spriteRenderer.color = standardColor;
		active = false;
	}

}

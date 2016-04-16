using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Texture2D buttonTexture;
    public GUIStyle style;
    public float x;
    public float y;

    public void Start()
    {

    }

    public void Update()
    {

    }

    public void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - (buttonTexture.width / 2), Screen.height / 2 - (buttonTexture.height / 2) + (Screen.height / 5), buttonTexture.width, buttonTexture.height), buttonTexture, style))
            startGame();
    }

    public void startGame()
    {
        Application.LoadLevel("MarkusTestScene");
        Debug.Log("Boop");
    }



}

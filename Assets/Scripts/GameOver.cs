using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{
    public GUIStyle style;

    public void Start()
    {

    }

    public void Update()
    {

    }

    public void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, Screen.width, Screen.height), "CLICK TO CONTINUE", style))
            startGame();
    }

    public void startGame()
    {
        Application.LoadLevel("TitleScene");
        Debug.Log("Boop");
    }



}

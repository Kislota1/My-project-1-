using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    private void OnEnable()
    {
        Player.onTouched += ConsoleMessage;
    }

    private void OnDisable()
    {
        Player.onTouched -= ConsoleMessage;
    }



    //private void ConsoleMessage()
    //{
       //Debug.Log("Кубик ударился о землю");
    //}
    private string ConsoleMessage()
    {
        return "Кубик ударился о землю";
    }
}

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
       //Debug.Log("����� �������� � �����");
    //}
    private string ConsoleMessage()
    {
        return "����� �������� � �����";
    }
}

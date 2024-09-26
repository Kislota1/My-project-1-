using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    //public static Action onTouched;

    public static Func<string> onTouched;

    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Я ударился");

        Debug.Log(onTouched?.Invoke());
      //onTouched?.Invoke();
    }
}

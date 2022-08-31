using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotate : MonoBehaviour
{
    public static event Action<string, int> Rotated = delegate { };

    private bool coroutineAllowed;

    private int numberShown;

    void Start()
    {
        coroutineAllowed = true;
        numberShown = 5;
    }

    private void OnMouseDown()
    {
        if (coroutineAllowed)
        {
            StartCoroutine("RotateWheel");
        }
    }

    private IEnumerator RotateWheel()
    {
        coroutineAllowed = false;

        for (int i = 0; i <= 11; i++)
        {
            transform.position = transform.position + new Vector3(0, -0.1f, 0);
            yield return new WaitForSeconds(0.01f);
        }
    
        coroutineAllowed = true;
        numberShown += 1;

        if (numberShown > 9){
            numberShown = 0;
        }

        Rotated(name, numberShown);
    
    }
}
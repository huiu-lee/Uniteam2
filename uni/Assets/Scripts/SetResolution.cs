using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Moble Screen Resolution Set ratio 16:9 juyoung
public class SetResolution : MonoBehaviour
{

    void Awake()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float scaleHeight = ((float)Screen.width / Screen.height) / ((float)16 / 9); //가로 세로
        float scaleWidth = 1f / scaleHeight;
        if(scaleHeight < 1)
        {
            rect.height = scaleHeight;
            rect.y = (1f - scaleHeight) / 2f;
        }
        else 
        {
            rect.width = scaleWidth;
            rect.y = (1f - scaleWidth)  / 2f;
        }
        camera.rect = rect;

    }
}

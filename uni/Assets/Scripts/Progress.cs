using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public Text per0, per1, per2, per3, per4, per5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void progresscontrol()
    {
        if(GameManager.isClear1 == true)
        {
            per0.text = "100 %";
            print("Ȯ��;��");
        }

        else if(GameManager.curScene == 1)
        {
            per2.text = "100 %";
        }

        else if (GameManager.curScene == 1)
        {
            per3.text = "100 %";
        }

        else if (GameManager.curScene == 1)
        {
            per4.text = "100 %";
        }

        else if (GameManager.curScene == 1)
        {
            per5.text = "100 %";
        }
    }
}
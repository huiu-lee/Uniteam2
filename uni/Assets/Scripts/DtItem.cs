using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DtItem : MonoBehaviour
{
    public Flowchart flowchart;
    //public GameObject x1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detective Diary Item Control
        if(flowchart.GetIntegerVariable("dtitemNum") == 1)
        {
            //2_lowmedicine //5_lighter
            GameObject.Find("Dt_GameObject").transform.GetChild(2).gameObject.SetActive(true);
        }
        if (flowchart.GetIntegerVariable("dtitemNum") == 2)
        {
            //3_lighter //5_lapply
            GameObject.Find("Dt_GameObject1").transform.GetChild(2).gameObject.SetActive(true);
        }
        if (flowchart.GetIntegerVariable("dtitemNum") == 3)
        {
            //3_kimtablet3
            GameObject.Find("Dt_GameObject2").transform.GetChild(2).gameObject.SetActive(true);
        }
        if (flowchart.GetIntegerVariable("dtitemNum") == 4)
        {
            //4_nenv
            GameObject.Find("Dt_GameObject").transform.GetChild(2).gameObject.SetActive(true);
        }



        //Detective Diary Memory Control
        if (flowchart.GetIntegerVariable("dtmemNum") == 1)
        {
            GameObject.Find("GameObject_m1").transform.GetChild(0).gameObject.SetActive(true);
        }
        if (flowchart.GetIntegerVariable("dtmemNum") == 2)
        {
            GameObject.Find("GameObject_m1").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("GameObject_m2").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("GameObject_m2").transform.GetChild(1).gameObject.SetActive(true);
            GameObject.Find("GameObject_m3").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("GameObject_m3").transform.GetChild(1).gameObject.SetActive(true);
        }
        if (flowchart.GetIntegerVariable("dtmemNum") == 3)
        {
            GameObject.Find("GameObject_m4").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("GameObject_m4").transform.GetChild(1).gameObject.SetActive(true);
            GameObject.Find("GameObject_m5").transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}

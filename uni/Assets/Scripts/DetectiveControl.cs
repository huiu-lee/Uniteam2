using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DetectiveControl : MonoBehaviour
{
    public GameObject dtcanvas;

    public GameObject intr, click;
    public Flowchart flowchart;
    public GameObject info1, info2, info3, info4, info5, info6, info7, info8;

    public void DetectiveClose()
    {
        if(intr.activeSelf == true)
        {
            intr.SetActive(false);
            info1.SetActive(false);
            info2.SetActive(false);
            info3.SetActive(false);
            info4.SetActive(false);
            info5.SetActive(false);
            info6.SetActive(false);
            info7.SetActive(false);
            info8.SetActive(false);
        }
        else
        {
            dtcanvas.SetActive(false);
            click.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void FlowStp()
    //{
    //    if(dtcanvas.activeSelf == true)
    //    {
    //        flowchart.StopAllBlocks();
    //    }
    //}
}

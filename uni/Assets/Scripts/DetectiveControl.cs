using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DetectiveControl : MonoBehaviour
{
    public GameObject dtcanvas;

    public GameObject intr, info, click;
    public Flowchart flowchart;

    public void DetectiveClose()
    {
        if(intr.activeSelf == true)
        {
            intr.SetActive(false);
            info.SetActive(false);
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

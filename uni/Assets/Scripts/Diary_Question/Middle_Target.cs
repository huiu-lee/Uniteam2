using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Middle_Target : MonoBehaviour
{

    private string curObjName;

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Character") {
            this.transform.GetComponent<Image>().sprite = other.gameObject.transform.GetComponent<Image>().sprite;
            curObjName = other.name;
        }
    }

    
    void Start()
    {

    }

    void Update()
    {
        
    }
}

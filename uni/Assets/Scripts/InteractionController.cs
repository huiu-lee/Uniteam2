using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    RaycastHit hitInfo;

    DialogueManager theDM;


    void Start()
    {
        theDM = FindObjectOfType<DialogueManager>();
    }

    void OnMouseDown()
    {
        theDM.ShowDialogue(hitInfo.transform.GetComponent<InteractionEvent>().GetDialogue());
        //theDM.ShowDialogue();
    }
}

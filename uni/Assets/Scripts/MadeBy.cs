using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MadeBy : MonoBehaviour
{
    public GameObject madeBy;
    public Button openMBBtn;
    public GameObject closeMBBtn;
    public Button optOpenBtn;
    public Button gameStartBtn;

    public void OpenMadeBy()
    {
        madeBy.SetActive(true);
        openMBBtn.interactable = false;
        optOpenBtn.interactable = false;
        gameStartBtn.interactable = false;

    }

    public void CloseMadeBy()
    {
        madeBy.SetActive(false);
        openMBBtn.interactable = true;
        optOpenBtn.interactable = true;
        gameStartBtn.interactable = true;
    }
}

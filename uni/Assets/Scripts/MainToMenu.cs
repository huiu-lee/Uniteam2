using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainToMenu : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData data)
    {
        LoadingManager.LoadScene("MainMenu");
    }
}

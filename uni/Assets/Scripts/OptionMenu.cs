using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    public GameObject option;
    public Button openOptBtn;
    public Button openMBBtn;
    public Button gameStartBtn;

    public void OptOpen()
    {
        option.SetActive(true);
        openOptBtn.interactable = false;
        openMBBtn.interactable = false;
        gameStartBtn.interactable = false;
    }

    public void OptClose()
    {
        option.SetActive(false);
        openOptBtn.interactable = true;
        openMBBtn.interactable = true;
        gameStartBtn.interactable = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        LoadingManager.LoadScene("MainMenu");
    }

    public void SoundOn()
    {

    }

    public void SoundOff()
    {

    }
}

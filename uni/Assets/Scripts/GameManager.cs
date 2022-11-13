
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager: SingletonAsComponent<GameManager>
{
    public static int curScene = 0;
    public static bool isClear1;
    public static bool isClear2;
    public static bool isClear3;
    public static bool isClear4;
    public static bool isClear5;
    public static bool isClear6;
    public static bool isClear7;
    public static int chapterNumber = 0;
}

// public class GameManager : MonoBehaviour
// {

//     public GameObject option;
//     public GameObject optionBtn;

//     void Start()
//     {
        
//     }

//     void Update()
//     {

//     }

//     public void OpenOptionWindow()
//     {
//         Time.timeScale = 0;

//         option.SetActive(true);
//         optionBtn.SetActive(false);
//     }

//     public void CloseOptionWindow()
//     {
//         Time.timeScale = 1.0f;

//         option.SetActive(false);
//         optionBtn.SetActive(true);
//     }
// }

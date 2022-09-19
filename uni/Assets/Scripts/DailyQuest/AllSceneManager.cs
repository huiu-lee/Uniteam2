using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSceneManager : MonoBehaviour
{
    
    void Start() {
        // Debug.Log("SceneNum : " + curScene);
    }

    void clearScene0() {
        Debug.Log("asdasaddadsadsadadsa");
        GameManager.isClear1 = true;
        Debug.Log(GameManager.curScene);
    }
    void clearScene1() {
        Debug.Log("asdasaddadsadsadadsa");
        GameManager.curScene = 1;
        Debug.Log(GameManager.curScene);

    }
    void clearScene2() {
        GameManager.curScene = 2;
        Debug.Log(GameManager.curScene);        
    }
    void clearScene3() {
        GameManager.curScene = 3;
        Debug.Log(GameManager.curScene);        
    }
    void clearScene4()
    {
        GameManager.curScene = 4;
        Debug.Log(GameManager.curScene);
    }
    void clearScene5()
    {
        GameManager.curScene = 5;
        Debug.Log(GameManager.curScene);
    }
}

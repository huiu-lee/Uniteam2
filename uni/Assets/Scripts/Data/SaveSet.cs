using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSet : MonoBehaviour
{
    private Transform chap1, chap2, chap3, chap4;
    //private GameObject lockch1, lockch2, lockch3, lockch4;
    TextAsset savedata; // json file Loader
    string stage;
    List<string> stages;
    //private int chapterNumber;
    

    // Start is called before the first frame update
    void Start()
    {
        chap1 = GameObject.Find("Content").transform.Find("Stage 1");
        chap2 = GameObject.Find("Content").transform.Find("Stage 2");
        chap3 = GameObject.Find("Content").transform.Find("Stage 3");
        chap4 = GameObject.Find("Content").transform.Find("Stage 4");

        //for chapter Lock Function
        //lockch1 = GameObject.Find("lock_stage1");
        //lockch2 = GameObject.Find("lock_stage2");
        //lockch3 = GameObject.Find("lock_stage3");
        //lockch4 = GameObject.Find("lock_stage4");
        Debug.Log(DataController.Instance.gameData.isClear1);
        Debug.Log(GameManager.isClear1);
        Debug.Log(GameManager.isClear2);


        savedata = Resources.Load<TextAsset>("savedata");
        stage = JsonUtility.FromJson<string>(savedata.text);
      
    }

    public void click()
    {
        if (GameManager.chapterNumber == 1)       // if (DataController.Instance.gameData.chapterNumbe1r123 == 1)
        {
            //lockch1.SetActive(false);
            chap1.gameObject.SetActive(true);
            GameManager.isClear1 = true;
        }
        else if (GameManager.chapterNumber == 2)
        {
            //lockch2.SetActive(false);
            chap2.gameObject.SetActive(true);
            GameManager.isClear1 = true;
            GameManager.isClear2 = true;
        }
        else if (GameManager.chapterNumber == 3)
        {
            //lockch3.SetActive(false);
            chap3.gameObject.SetActive(true);
            GameManager.isClear1 = true;
            GameManager.isClear2 = true;
            GameManager.isClear3 = true;
        }
        else if (GameManager.chapterNumber == 4)
        {
            //lockch4.SetActive(false);
            chap4.gameObject.SetActive(true);
            GameManager.isClear1 = true;
            GameManager.isClear2 = true;
            GameManager.isClear3 = true;
            GameManager.isClear4 = true;
        }
        /*
        else if (chapterNumber == 5)
        {
            //GameManager.isClear4 = true;
            //GameObject.Find("Content").transform.Find("Stage 4").gameObject.SetActive(true);
            print(chapterNumber);
        }
        */
    }

    public void show()
    {   
        if(GameManager.isClear1 == true)   //if (DataController.Instance.gameData.2isClear1 == true)
        {
            //lockch1.SetActive(false);
            chap1.gameObject.SetActive(true);
        }
        if (GameManager.isClear2 == true)
        {
            //lockch2.SetActive(false);
            chap2.gameObject.SetActive(true);
        }
        if (GameManager.isClear3 == true)
        {
            //lockch3.SetActive(false);
            chap3.gameObject.SetActive(true);
        }
        if (GameManager.isClear4 == true)
        {
            //lockch4.SetActive(false);
            chap4.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        show();

    //     //������ �׽�Ʈ��
    //     if (Input.GetKeyDown("z"))
    //     {
    //         GameManager.chapterNumber += 1;
    //         click();
    //     }

    //     //�׽�Ʈ��
    //     if (Input.GetKeyDown(KeyCode.Escape))
    //     {
    //         GameManager.isClear1 = false;
    //         GameManager.isClear2 = false;
    //         GameManager.isClear3 = false;
    //         GameManager.isClear4 = false;
    //         GameManager.chapterNumber = 0;

    //         print(GameManager.isClear1);
    //         print(GameManager.isClear2);
    //         print(GameManager.isClear3);
    //         print(GameManager.isClear4);
    //         print(GameManager.chapterNumber);
    //     }

    //     print("é�ͳѹ���" + GameManager.chapterNumber);
    }
}


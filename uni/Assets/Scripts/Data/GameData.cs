using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class GameData
{
    /*
    private Transform chap1 = GameObject.Find("Content").transform.Find("Stage1");
    private Transform chap2 = GameObject.Find("Content").transform.Find("Stage2");
    private Transform chap3 = GameObject.Find("Content").transform.Find("Stage3");
    private Transform chap4 = GameObject.Find("Content").transform.Find("Stage4");
    */

    //�� é���� ��ݿ���
    public bool isClear1 = true;
    public bool isClear2;
    public bool isClear3;
    public bool isClear4;

    public int chapterNumber = 0;
}

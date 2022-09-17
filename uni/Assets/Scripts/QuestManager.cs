using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using System;

public class QuestManager : MonoBehaviour
{
    public List<string> list = new List<string>();
    public Flowchart flowchart;
    int sizeOfList;

    public GameObject questBtn;
    public GameObject questTxtObj;
    public Text questTxt;
    
    void Start()
    {
        sizeOfList = list.Count;

        //chapter 0
        list.Add("병실에서 내 휴대폰을 찾자");
        list.Add("친구에게 말을 걸어보자");
        list.Add("병실을 수색해서 파우치 지퍼를 찾자");
        list.Add("파우치에 지퍼를 합성해보자");
        list.Add("휴대폰에 보조배터리를 연결하자");
        // chapter 1
        list.Add("방에서 컴퓨터를 찾자");
        list.Add("USB를 사용해보자"); // 6
        list.Add("식당에 가서 다른 친구들과 얘기해보자");
        list.Add("교무실로 가자");
        list.Add("기숙사로 돌아가서 쉬자");
        // chapter 2
        list.Add("몰래 관리사무소로 이동하자"); // 10
        list.Add("자습실로 이동하자");
        list.Add("강의실로 이동하자");
        list.Add("관리사무소로 가보자");
        list.Add("창고에 가보자");
        //chapter 3
        list.Add("창고에가보자"); // 15
        list.Add("증거물을 수집하자");
        list.Add("기숙사에가서 휴대폰을 충전시켜보자");
        list.Add("여자 기숙사 방에서 김예지를 조사해보자");
        list.Add("보건실에 가보자");
        list.Add("고혈압 약을 찾아 현성이에게 주자");
        //chapter 4
        list.Add("남자 기숙사 노인성의 방을 조사해보자");//21
        list.Add("노인성 자리를 조사해보자");
        list.Add("자습실로 가서 장진혁 자리를 조사해보자");
        list.Add("관리사무소로 가자");
        list.Add("지갑 내용물을 확인하자");
        //chapter5
        list.Add("교무실로 가자");//26
        list.Add("자습실로 가보자");
        //chapter6
        list.Add("교무실로 이동하자");//28
        list.Add("지하 비품실에 가보자");
    }

    void Update()
    {
        int questNum = flowchart.GetIntegerVariable("questNum");
        if (questNum > 50)
        {
            questTxtObj.SetActive(false);
            questBtn.SetActive(false);
        }
        else
        {
            questTxtObj.SetActive(true);
            questBtn.SetActive(true);
            questTxt.text = list[questNum];
        }
    }
}

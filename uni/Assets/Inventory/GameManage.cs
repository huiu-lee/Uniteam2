using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using UnityEngine.UI;
//using System.Collections;
//using System.Linq;



[System.Serializable] //직렬화하여 인스펙터 창에 나타냄
public class Item
{

    public Item(string _Name,string _Type,  string _Explain, string _Number, bool _isUsing)
    {Name = _Name;Type = _Type;  Explain = _Explain; Number = _Number; isUsing = _isUsing;}
    public string Name,Type,  Explain, Number;
    public bool isUsing;
}

public class GameManage : MonoBehaviour
{

    public TextAsset ItemDatabase; //txt 파일 아이템 데이터 참조
    public List<Item> AllItemList,MyItemList,curItemList;
    public string curType = "Basic";
    public GameObject[] Slot, UsingImage;
    public Image[] TabImage,ItemImage;
    public Sprite TabIdleSprite, TabSelectSprite;
    public Sprite[]  ItemSprite;
    public GameObject ExplainPanel;
    public InputField ItemNameInput, ItemNumberInput;
    IEnumerator PointerCoroutine;
    public string curitemName = "";

   

    void Start()
    {
        //전체 아이템 리스트 불러오기
        string[] line = ItemDatabase.text.Substring(0, ItemDatabase.text.Length -1).Split('\n');
        for(int i=0; i< line.Length; i++)
        {
            string[] row = line[i].Split('\t');
            AllItemList.Add(new Item(row[0], row[1], row[2], row[3], row[4] == "TRUE"));
        }

        

        Load();
    }

    public void ItemClick(string itemName)
   {
        //curitemName = itemName; 
        //curItemList = MyItemList.FindAll(x => x.Name == itemName);
 
            curitemName = itemName; 
            curItemList = MyItemList.FindAll(x => x.Name == itemName);
            
        for(int i = 0; i < Slot.Length; i++)
        { 
            
            
            //curItemList.Add(new Item(row[0], row[1], row[2], row[3], row[4] == "TRUE"));
            bool isExist = true;//i < curItemList.Count; //isExist 슬롯 존재 여부
            Slot[i].SetActive(isExist);
            Slot[i].GetComponentInChildren<Text>().text = i < curItemList.Count ? curItemList[i].Name + "/" + curItemList[i].isUsing : "";
        
            if(isExist)
            {
                ItemImage[i].sprite = ItemSprite[AllItemList.FindIndex(x=> x.Name == curItemList[i].Name)];
                UsingImage[i].SetActive(curItemList[i].isUsing);
                
            }
            //Item curItem = MyItemList.Find(x=> x.Name == ItemNameInput.text);
        }
/*
        int tabNum = 0;
        switch(tabName)
        {
            case "Basic" : tabNum = 0; break;
            case "Compose" : tabNum = 1; break;
        }
        
        for (int i=0 ;i<TabImage.Length; i++)
            TabImage[i].sprite = i == tabNum ? TabSelectSprite : TabIdleSprite;
            */
    }



    public void GetItemClick()
    {
        Item curItem = MyItemList.Find(x=> x.Name == ItemNameInput.text);
        if(curItem != null)
        {
            curItem.Number = (int.Parse(curItem.Number) + int.Parse(ItemNumberInput.text)).ToString();
        }
        else
        {
            Item curAllItem = AllItemList.Find(x=> x.Name == ItemNameInput.text);
            if(curAllItem != null) MyItemList.Add(curAllItem);
        }
        Save();
    }
    
    public void RemoveItemClick()
    {
        Item curItem = MyItemList.Find(x=> x.Name == ItemNameInput.text); 
    }

    public void SlotClick(int slotNum) //아이템 사용 여부
    {
        Item curItem = curItemList[slotNum];
        Item usingItem = curItemList.Find(x => x.isUsing == true);

        if(curType == "Basic")
        {
            if(usingItem != null) usingItem.isUsing = false;
            curItem.isUsing = true;
        }
        else
        {
            curItem.isUsing = !curItem.isUsing;
            if(usingItem != null) usingItem.isUsing = false;
        }

        Save();
    }

    public void TabClick(string tabName)
    {
        curType = tabName; 
        curItemList = MyItemList.FindAll(x => x.Type == tabName);

        for(int i = 0; i < Slot.Length; i++)
        {
            bool isExist = i < curItemList.Count;
            Slot[i].SetActive(isExist);
            Slot[i].GetComponentInChildren<Text>().text = i < curItemList.Count ? curItemList[i].Name + "/" + curItemList[i].isUsing : "";

            if(isExist)
            {
                ItemImage[i].sprite = ItemSprite[AllItemList.FindIndex(x=> x.Name == curItemList[i].Name)];
                UsingImage[i].SetActive(curItemList[i].isUsing);
            }
        }
/*
        int tabNum = 0;
        switch(tabName)
        {
            case "Basic" : tabNum = 0; break;
            case "Compose" : tabNum = 1; break;
        }
        for (int i=0 ;i<TabImage.Length; i++)
            TabImage[i].sprite = i == tabNum ? TabSelectSprite : TabIdleSprite;*/
    }

    public void PointerEnter(int slotNum)
    {
        PointerCoroutine = PointerEnterDelay(slotNum);
        StartCoroutine(PointerCoroutine);

        ExplainPanel.GetComponentInChildren<Text>().text = curItemList[slotNum].Name;
        ExplainPanel.transform.GetChild(2).GetComponent<Image>().sprite = Slot[slotNum].transform.GetChild(1).GetComponentInChildren<Image>().sprite;
        ExplainPanel.transform.GetChild(3).GetComponent<Text>().text = curItemList[slotNum].Number + "개";
        ExplainPanel.transform.GetChild(4).GetComponent<Text>().text = curItemList[slotNum].Explain; 
    }

    IEnumerator PointerEnterDelay(int slotNum)
    {
        yield return new WaitForSeconds(0.5f);
        ExplainPanel.SetActive(true);
    }

    public void PointerExit(int slotNum)
    {
        StopCoroutine(PointerCoroutine);
        ExplainPanel.SetActive(false);
    }


    void Save()
    {
        string jdata = JsonConvert.SerializeObject(MyItemList);
        File.WriteAllText(Application.dataPath+"/Inventory/MyItemText.txt",jdata);

        //TabClick(curType);
        ItemClick(curitemName);
    }

    void Load()
    {
        string jdata = File.ReadAllText(Application.dataPath+"/Inventory/MyItemText.txt");
        MyItemList = JsonConvert.DeserializeObject<List<Item>>(jdata);

        //TabClick(curType);
        ItemClick(curitemName);
    }
  
}

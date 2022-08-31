using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class DataManager : MonoBehaviour
{
    public GameObject item; 
    public GameObject text;
    public TextAsset json;
    
    private Sprite sprite;
    private Text plain;
    List<string> images;
    List<string> whos;
    List<string> names;
    List<string> quests;
    GameObject contents;

// if(GameManager.Instance.curScene == 0) {}
    void Update() {
        if(contents.transform.childCount == 0) {
            Debug.Log("clear");
            Clear();
            SceneManager.LoadScene("MainMenu");
        }
    }

    void Start() {
        Debug.Log(GameManager.curScene);
        images = new List<string>();
        names = new List<string>();
        whos = new List<string>();


        TextAsset textAsset = Resources.Load<TextAsset>("data");
        ItemList itemList = JsonUtility.FromJson<ItemList>(textAsset.text);
        QuestList questList = JsonUtility.FromJson<QuestList>(textAsset.text);
        foreach(Quests qt in questList.quests0){
            Debug.Log(qt.quest);
            Debug.Log(qt.id);

            GameObject newItem2 =  Instantiate(text);
            newItem2.transform.SetParent(GameObject.FindGameObjectWithTag("DailyQuest").transform);  
            GameObject childText = newItem2.transform.GetChild(0).gameObject;
            childText.transform.GetComponent<Text>().text = qt.quest;
            contents = GameObject.FindGameObjectWithTag("DailyItem").transform.gameObject;
            
        }

        if(GameManager.curScene == 0)
        {
            foreach(Items it in itemList.items0){
                    names.Add(it.name);
                    images.Add(it.image);
                    whos.Add(it.whos);
            }
        }
        else if(GameManager.curScene == 1)
        {
            foreach (Items it in itemList.items1)
            {
                names.Add(it.name);
                images.Add(it.image);
                whos.Add(it.whos);
            }
        }
        else if (GameManager.curScene == 2)
        {
            foreach (Items it in itemList.items2)
            {
                names.Add(it.name);
                images.Add(it.image);
                whos.Add(it.whos);
            }
        }        
        else if (GameManager.curScene == 3)
        {
            foreach (Items it in itemList.items3)
            {
                names.Add(it.name);
                images.Add(it.image);
                whos.Add(it.whos);
            }
        } 
        else if (GameManager.curScene == 4)
        {
            foreach (Items it in itemList.items4)
            {
                names.Add(it.name);
                images.Add(it.image);
                whos.Add(it.whos);
            }
        } 
        else if (GameManager.curScene == 5)
        {
            foreach (Items it in itemList.items5)
            {
                names.Add(it.name);
                images.Add(it.image);
                whos.Add(it.whos);
            }
        }                 
        for(int i=0; i<images.Count; i++)
        {
            GameObject newItem =  Instantiate(item);
            newItem.transform.SetParent(GameObject.FindGameObjectWithTag("DailyItem").transform);
            newItem.name = names[i];
            sprite = Resources.Load<Sprite>(images[i]);
            GameObject childItem = newItem.transform.GetChild(0).gameObject;
            childItem.transform.GetComponent<Image>().sprite = sprite;
            childItem.name = whos[i];
            Debug.Log(sprite + "sprite");
        }
    }
    void Clear()
    {
        if(GameManager.curScene == 1)
        {
            GameManager.isClear2 = true;
        }
        else if(GameManager.curScene == 2)
        {
            GameManager.isClear3 = true;
        }
        else if (GameManager.curScene == 3)
        {
            GameManager.isClear4 = true;
        }
        else if (GameManager.curScene == 4)
        {
            GameManager.isClear4 = true;
        }        
    }
}

[System.Serializable]
public class ItemList {
    public Items[] items0;
    public Items[] items1;
    public Items[] items2;
    public Items[] items3;
    public Items[] items4;

    public Items[] items5;

}
[System.Serializable]
public class QuestList {
     public Quests[] quests0;
}
[System.Serializable]
public class Quests {
   public string quest; 
   public string id; 

}

[System.Serializable]
public class Items {
    public string name;
    public string des;
    public string whos; 
    public string image;
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //File, 

public class getQuesJson : MonoBehaviour
{

    public List<Plain> jianAnswer = new List<Plain>();
    public GameObject Target;
    public GameObject Item;

    private string TargetText;
    private string ItemText;

    // Start is called before the first frame update
    void Start()
    {
        string jsonStr = File.ReadAllText(Application.dataPath + "/Resources/diaryQuestion.json");
        JsonData readJson = JsonUtility.FromJson<JsonData>(jsonStr);
        foreach(Plain it in readJson.jian) {
            Plain join = new Plain();
            join.name = it.name;
            join.description = it.description;

            jianAnswer.Add(join);
        }
        Debug.Log(jianAnswer);
    }

    public void jsonParse () {

    }
    public void onClickQeustion() { 
        TargetText = Target.name;
        ItemText = Item.name;
        


    }
    public void onClickReset() {

    }
}

[System.Serializable]
public class JsonData 
{   
    public Plain[] jian;
    public Plain[] other;
    
}

[System.Serializable]
public class Plain 
{
    public string name;
    public string description;
}

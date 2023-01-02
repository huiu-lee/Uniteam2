using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

public class QuestionManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Jian jians = new Jian();
    private string[] items;
    private string question1;
    private string question2;
    private string answer1;
    private string answer2;

    void Start()
    {
        string jsonText = File.ReadAllText(Application.dataPath + "/Resources/diaryItems.json");
        Root readJson = JsonUtility.FromJson<Root>(jsonText);
        Root newtonJson = JsonConvert.DeserializeObject<Root>(jsonText);
        for(int idx=0; idx < newtonJson.jian.nonsulmunjae.Count; idx++) {
            Debug.Log(newtonJson.jian.nonsulmunjae[idx]);
        }
    }
}

[System.Serializable]

public class Gihyun
{
    public List<string> nonsulmunjae { get; set; }
}
[System.Serializable]

public class Jian
{
    public List<string> nonsulmunjae { get; set; }
}
[System.Serializable]

public class Root
{
    public Jian jian { get; set; }
    public Gihyun gihyun { get; set; }
}


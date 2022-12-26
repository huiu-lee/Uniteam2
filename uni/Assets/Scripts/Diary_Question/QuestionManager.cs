using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class QuestionManager : MonoBehaviour
{
    // Start is called before the first frame update
    private string question1;
    private string answer1;
    private string question2;
    private string answer2;

    void Start()
    {
        string jsonText = File.ReadAllText(Application.dataPath + "/Resources/diaryItems");
        dCharacter readJson = JsonUtility.FromJson<dCharacter>(jsonText);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class dCharacter
{
    public List<List<dQuestion>> jian;
    public List<List<dQuestion>> gihyun;

}
public class dItem  
{
}
public class dQuestion {
    public string question1; 
    public string answer1;
    public string question2;
    public string answer2;
}

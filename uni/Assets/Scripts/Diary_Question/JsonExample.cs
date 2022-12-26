using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //File, 


[System.Serializable]
public class Data
{
    public int level;
    public List<string> item;

    public void printD()
    {
        Debug.Log(level);
        Debug.Log(item);
    }
}
public class JsonExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Data data = new Data();
        data.level = 4;
        data.item = new List<string>();
        data.item.Add("1234");
        data.item.Add("5678");

        string str = JsonUtility.ToJson(data); //convert Json

        Debug.Log(str);

        Data data2 = JsonUtility.FromJson<Data>(str); //convert gameobject
        data2.printD();

        /********************************************************************/
        Data dataJ = new Data();
        dataJ.level = 5;
        dataJ.item = new List<string>();
        dataJ.item.Add("chapter1");
        dataJ.item.Add("chapter2");

        /* create json file ,Application.datapath => current work dir */
        File.WriteAllText(Application.dataPath + "/save.json", JsonUtility.ToJson(dataJ));

        /* load json file */
        string jsonStr = File.ReadAllText(Application.dataPath + "/save.json");
        Data readJson = JsonUtility.FromJson<Data>(jsonStr);
        readJson.printD();

    }
}

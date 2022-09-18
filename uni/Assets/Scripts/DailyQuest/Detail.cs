using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detail : MonoBehaviour
{
    
    public GameObject srcObj;
    private GameObject parent;
    private GameObject targetObj;
    private Sprite img; 
    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("Canvas_Detail");
        // Debug.Log(targetObj.name);
    }
    public void ItemDeatil() {
        img = srcObj.GetComponent<Image>().sprite;
        parent.transform.GetChild(0).gameObject.SetActive(true);
        targetObj = GameObject.Find("Detail_Item");
        targetObj.GetComponent<Image>().sprite = img;
        // targetObj.transform.parent.gameObject.SetActive(true);
    }


}


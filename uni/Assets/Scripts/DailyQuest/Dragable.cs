using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dragable : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    string checker;
    string target;
    public static Vector2 DefaultPos;
    Transform  tragetTransform;
    GameObject targetSlot;
    public GameObject slotPrefab;
    public GameObject childPrefab;
    private Sprite ItemImage;
    

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        DefaultPos = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position; 
        this.transform.position = currentPos;

   
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        this.transform.position = DefaultPos;
        Debug.Log(eventData);
        if(checker == target)
        {
            Debug.Log("nice");


            GameObject Slot = Instantiate(slotPrefab);
            ItemImage = this.transform.GetComponent<Image>().sprite;
            Debug.Log(ItemImage.name);
            childPrefab = Slot.transform.GetChild(0).gameObject;
            childPrefab.transform.GetComponent<Image>().sprite = ItemImage;
            Slot.transform.SetParent(tragetTransform);
            Debug.Log(tragetTransform);
            
            Destroy(this.transform.parent.gameObject);

        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        checker = this.name;
        target = other.name;

        targetSlot = other.gameObject.transform.GetChild(0).gameObject;
        tragetTransform = targetSlot.transform;
    }    
}

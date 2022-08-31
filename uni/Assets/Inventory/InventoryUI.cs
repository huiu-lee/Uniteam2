using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public GameObject inventoryPanel;
    bool activeInventory = false;

    private void Start()
    {
        inventoryPanel.SetActive(activeInventory);
    }

    public void InventoryOn(){
            //activeInventory = true;
            //inventoryPanel.SetActive(activeInventory);
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);

    }


    private void Update()
    {
     //     public void InventoryOn{
     //     activeInventory = true;
          // inventoryPanel.SetActive(activeInventory);
          //  activeInventory = !activeInventory;
          //  inventoryPanel.SetActive(activeInventory);
    }
    
}

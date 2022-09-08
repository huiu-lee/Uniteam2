using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGenerator : MonoBehaviour
{
    public Flowchart flowchart;

    public Collection items;

    List<Image> ItemPos = new List<Image>();

    List<Image> Slots = new List<Image>();

    //���� ��ư �̹���
    public Sprite selectedImage;
    public Sprite unselectedImage;

    //������ �ִ� ������ ��
    int count = 0;

    //���õ� ��ư ����
    int selectCount = 0;

    //��ư ����
    int buttonCount = 14;

    string preBtnName = "";

    string selected1;
    string selected2;

    // for use item
    // int chapterNum = flowchart.GetIntegerVariable("chapterNum");


    void Start()
    {
        //Slot �Ҵ�
        for (int i = 1; i < buttonCount + 1; i++)
        {
            string objName = "Slot" + i;
            Slots.Add(GameObject.Find(objName).GetComponent<Image>());
        }

        //itemPos �Ҵ�
        for (int i = 1; i < buttonCount + 1; i++)
        {
            string objName = "itemPos" + i;
            ItemPos.Add(GameObject.Find("Item" + i).transform.Find(objName).GetComponent<Image>());
        }

        GameObject.Find("Canvas_Inventory").SetActive(false);

        //Debug.Log("Slot List : " + Slots.Count);
        //Debug.Log("ItemPos List : " + ItemPos.Count);

    }

    void Update()
    {
        count = 0;

        foreach (GameObject item in items)
        {
            ItemPos[count].sprite = item.GetComponent<SpriteRenderer>().sprite;
            ItemPos[count].gameObject.SetActive(true);

            count++;
        }

    }

    #region �ռ��ϱ� ��ư
    public void Combine()
    {
        if (selectCount == 2)
        {

            if (selected1 == "1_zipper" && selected2 == "1_pouch" || selected1 == "1_pouch" && selected2 == "1_zipper")
            {
                Flowchart.BroadcastFungusMessage("Combine pouch & zipper");
                InitializeInventory();

                foreach (Image slot in Slots)
                {
                    slot.sprite = unselectedImage;
                }
                selectCount = 0;
            }
            else if (selected1 == "1_battery" && selected2 == "1_phone" || selected1 == "1_phone" && selected2 == "1_battery")
            {
                Flowchart.BroadcastFungusMessage("Combine phone & battery");
                InitializeInventory();

                foreach (Image slot in Slots)
                {
                    slot.sprite = unselectedImage;
                }
                selectCount = 0;
            }

            else if (selected1 == "2_pencil" && selected2 == "2_imnote1" || selected1 == "2_imnote1" && selected2 == "2_pencil")
            {
                Flowchart.BroadcastFungusMessage("Combine pencil & note");
                InitializeInventory();

                foreach (Image slot in Slots)
                {
                    slot.sprite = unselectedImage;
                }
                selectCount = 0;
            }

            else
            {
                Flowchart.BroadcastFungusMessage("Wrong item combine");
            }

        }
    }
    #endregion


    #region decompose

    public void Decompose()
    {
        if (selectCount == 1)
        {
            if (selected1 == "2_keyset")
            {
                Flowchart.BroadcastFungusMessage("Decompose 2_keyset");
                InitializeInventory();

                foreach (Image slot in Slots)
                {
                    slot.sprite = unselectedImage;
                }
                selectCount = 0;
            }

            else if (selected1 == "3_kimpencilcase")
            {
                Flowchart.BroadcastFungusMessage("Decompose pencilcase");
                InitializeInventory();

                foreach (Image slot in Slots)
                {
                    slot.sprite = unselectedImage;
                }
                selectCount = 0;
            }

            else if (selected1 == "4_nclutch")
            {
                Flowchart.BroadcastFungusMessage("Decompose 4_nclutch");
                InitializeInventory();

                foreach (Image slot in Slots)
                {
                    slot.sprite = unselectedImage;
                }
                selectCount = 0;
            }


            else if (selected1 == "4_jframe")
            {
                Flowchart.BroadcastFungusMessage("Decompose 4_jframe");
                InitializeInventory();

                foreach (Image slot in Slots)
                {
                    slot.sprite = unselectedImage;
                }
                selectCount = 0;
            }

            else if (selected1 == "4_hwallet")
            {
                Flowchart.BroadcastFungusMessage("Decompose 4_hwallet");
                InitializeInventory();

                foreach (Image slot in Slots)
                {
                    slot.sprite = unselectedImage;
                }
                selectCount = 0;
            }


            else
            {
                Flowchart.BroadcastFungusMessage("Wrong item Decompose");
            }
        }
    }

    #endregion

    #region useitem

    public void Use()
    {
        if (selectCount == 1)
        {   
            if (selected1 == "0_usb" && flowchart.GetStringVariable("stageFlag1") == "지안책상" && flowchart.GetBooleanVariable("useUsb") == false
            && flowchart.GetIntegerVariable("stageFlag2") == 1)
            {
                Flowchart.BroadcastFungusMessage("usb_to_notebook_click");
                InitializeInventory();

                flowchart.SetBooleanVariable("useUsb", true);


                selectCount = 0;
            }

            else if (selected1 == "2_entrylist")
            {
                Flowchart.BroadcastFungusMessage("Use entrylist");
                InitializeInventory();

                selectCount = 0;
            }

            else if (selected1 == "2_toiletkey")
            {
                Flowchart.BroadcastFungusMessage("Use toiletkey");
                InitializeInventory();

                selectCount = 0;
            }

            else if (selected1 == "2_storekey")
            {
                Flowchart.BroadcastFungusMessage("Use storekey");
                InitializeInventory();

                selectCount = 0;
            }

            else if (selected1 == "3_nophone")
            {
                Flowchart.BroadcastFungusMessage("Use phone");
                InitializeInventory();

                selectCount = 0;
            }

            else if (selected1 == "1_spray" && flowchart.GetIntegerVariable("stageNum") == 2 && flowchart.GetBooleanVariable("useSpray") == false)
            {
                Flowchart.BroadcastFungusMessage("Use spray");
                InitializeInventory();

                flowchart.SetBooleanVariable("useSpray", true);

                selectCount = 0;
            }

            else if (selected1 == "1_phone" && flowchart.GetBooleanVariable("monitor") == false)
            {
                Flowchart.BroadcastFungusMessage("Use phone to monitor");
                InitializeInventory();

                flowchart.SetBooleanVariable("monitor", true);

                selectCount = 0;
            }

            else if (selected1 == "5_lplanner1" && flowchart.GetIntegerVariable("stageNum") == 3)
            {
                Flowchart.BroadcastFungusMessage("Use Planner");
                InitializeInventory();

                selectCount = 0;
            }
        }
    }
    #endregion


    #region ��ư ���ý�
    public void ButtonSelected(Image btn)
    {
        //nothing unselect
        if (preBtnName != btn.name)
        {
            btn.sprite = selectedImage;
            selectCount++;
            preBtnName = btn.name;

        }
        else if (selectCount == 1)
        {
            btn.sprite = unselectedImage;
            selectCount--;
            preBtnName = "";
        }
        else
        {
            btn.sprite = selectedImage;
            selectCount++;
        }

        //2 unselect
        if (selectCount > 2)
        {
            foreach (Image slot in Slots)
            {
                slot.sprite = unselectedImage;
            }
            selectCount = 0;
        }

        if (selectCount == 1)
        {
            selected1 = ItemPos[int.Parse(btn.name[4].ToString()) - 1].sprite.name.ToString();
            Debug.Log("selected1 : " + selected1);
        }
        else if (selectCount == 2)
        {
            selected2 = ItemPos[int.Parse(btn.name[4].ToString()) - 1].sprite.name.ToString();
            Debug.Log("selected2 : " + selected2);
        }
        else
        {
            selected1 = "";
            selected2 = "";
        }



        Debug.Log("selectCount : " + selectCount);
    }
    #endregion




    #region clear inventory
    public void InitializeInventory()
    {
        foreach (Image item in ItemPos)
        {
            item.sprite = null;
            item.gameObject.SetActive(false);
        }
    }
    #endregion

    public void ShowItemDetail(int num)
    {
        if (ItemPos[num].sprite != null)
        {
            string itemName = ItemPos[num].sprite.name;
            flowchart.SetStringVariable("itemDetail", itemName);

            Flowchart.BroadcastFungusMessage("Show item detail");
        }
    }
}
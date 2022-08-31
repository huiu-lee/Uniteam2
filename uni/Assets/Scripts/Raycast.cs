using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Raycast : MonoBehaviour
{
    public Flowchart flowchart;
    private int checkPhone = 0; // 플로우 차트에 사용되는 변수

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("clicked!"); 
                checkPhone = checkPhone + 1;
                flowchart.SetIntegerVariable("checkPhone", checkPhone);
           
            }   
        }
    }
}

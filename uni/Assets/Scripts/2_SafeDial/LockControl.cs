using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    private int[] result, correctCombination;

    private string ck;

    // Start is called before the first frame update
    void Start()
    {
        result = new int[3] { 5, 5, 5 };
        correctCombination = new int[3] { 2, 5, 3 };
        Rotate.Rotated += CheckResults;
    }

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "ScrollDial1":
                result[0] = number;
                break;

            case "ScrollDial2":
                result[1] = number;
                break;

            case "ScrollDial3":
                result[2] = number;
                break;
        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
        {
            Debug.Log("Open!");
            ck = "ok";
        }
    }

    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }

    public string GiveNCheck()
    {
        if (ck == "ok")
        {
            return "253";
        }
        else
        {
            return "";
        }
    }
}

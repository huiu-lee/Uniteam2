using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    private int[] result, correctCombination;
    // Start is called before the first frame update
    void Start()
    {
        result = new int[]{4, 4, 4};
        correctCombination = new int[] {2, 5, 3};
        Rotate.Rotated += CheckResults;
    }


    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "Dial1":
                result[0] = number;
                break;
            
            case "Dial2":
                result[1] = number;
                break;
            
            case "Dial3":
                result[2] = number;
                break;
        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
        {
            Debug.Log("Open!");
        }
    }

    private void OnDestroy() {
        Rotate.Rotated -= CheckResults;
    }   
}

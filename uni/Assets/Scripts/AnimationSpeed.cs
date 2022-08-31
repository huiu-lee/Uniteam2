using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeed : MonoBehaviour
{
    public Animator animSpeed;

    // 기본 속도
    public void NormalSpeed()
    {
        animSpeed.SetFloat("test_Float", 1);
    }

    // 빠르게
    public void FastSpeed()
    {
        animSpeed.SetFloat("test_Float", 2);
    }
}

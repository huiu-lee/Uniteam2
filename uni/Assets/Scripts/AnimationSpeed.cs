using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeed : MonoBehaviour
{
    public Animator animSpeed;

    // �⺻ �ӵ�
    public void NormalSpeed()
    {
        animSpeed.SetFloat("test_Float", 1);
    }

    // ������
    public void FastSpeed()
    {
        animSpeed.SetFloat("test_Float", 2);
    }
}

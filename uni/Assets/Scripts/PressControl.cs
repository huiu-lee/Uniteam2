using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using Fungus;
using UnityEngine.UI;

public class PressControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    public Flowchart flowchart; // fungus flow
    private bool isPressed = false; // 눌리지 않음
    private float pointerDownTimer; // 시간 측정
    private bool isTimeDone = false;

    [SerializeField]
    public float requiredTime; // 누르고 있어야 하는 시간
    public UnityEvent onLongClick;

    [SerializeField]
    private Image fillImage;

    public void OnPointerDown (PointerEventData eventData) {
        isPressed = true;
        Debug.Log("Press");
    }

    public void OnPointerUp (PointerEventData eventData) {
        Reset();
        Debug.Log("No Press");
    }
    
    // Update is called once per frame
    private void Update()
    {
        if (isPressed) {
            // 누르고 있는 상태
            pointerDownTimer += Time.deltaTime;
            Debug.Log("pointerDownTimer: " + pointerDownTimer);
            if (pointerDownTimer > requiredTime) {
                if (onLongClick != null) {
                    onLongClick.Invoke();
                    isTimeDone = true;
                    flowchart.SetBooleanVariable("isTimeDone", isTimeDone);
                }
                Reset();
            }
            fillImage.fillAmount = pointerDownTimer / requiredTime;
        }
    }

    private void Reset() {
        isPressed = false;
        pointerDownTimer = 0;
        fillImage.fillAmount = pointerDownTimer / requiredTime;
    }
    
    public void vibe()
    {
        Handheld.Vibrate();
    }

}

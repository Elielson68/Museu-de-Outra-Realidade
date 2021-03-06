using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public MoveObject moveController;
    public bool isPressed;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    void Update()
    {
        if(isPressed)
        {
            GetComponent<Button>().onClick.Invoke();
        }    
    }
}

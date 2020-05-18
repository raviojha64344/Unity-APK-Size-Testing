using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ColorChange : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnMouseUp()
    {
        Debug.Log("OnMouseUp");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}

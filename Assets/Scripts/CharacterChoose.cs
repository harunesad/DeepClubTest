using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterChoose : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        int index = Convert.ToInt32(gameObject.name);
        PlayerPrefs.SetInt("Index", index);
    }
}

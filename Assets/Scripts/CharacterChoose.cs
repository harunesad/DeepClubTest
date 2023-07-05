using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterChoose : MonoBehaviour
{
    [SerializeField] Color color;
    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    int index = Convert.ToInt32(gameObject.name);
    //    PlayerPrefs.SetInt("Index", index);
    //}
    private void Start()
    {
        Material material = GetComponentInChildren<MeshRenderer>().material;
        material.SetColor("_EmissionColor", color * 0);
    }
    private void OnMouseDown()
    {
        if (MenuManager.menu.mat != null)
        {
            MenuManager.menu.mat.SetColor("_EmissionColor", color * 0);
        }
        MenuManager.menu.mat = transform.GetComponentInChildren<MeshRenderer>().material;
        MenuManager.menu.mat.SetColor("_EmissionColor", color * 5);
        int index = Convert.ToInt32(gameObject.name);
        PlayerPrefs.SetInt("Index", index);
    }
}

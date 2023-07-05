using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager menu;
    public Material mat;
    int characterChoose;
    [SerializeField] Button playButton;
    private void Awake()
    {
        menu = this;
        characterChoose = PlayerPrefs.GetInt("Choose");
        if (characterChoose == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            PlayerPrefs.SetInt("Index", -1);
            playButton.onClick.AddListener(Play);
        }
    }
    void Play()
    {
        if (PlayerPrefs.GetInt("Index") != -1)
        {
            PlayerPrefs.SetInt("Choose", 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

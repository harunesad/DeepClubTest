using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> characters;
    GameObject myCharacter;
    public GameObject interactebale;
    public GameObject eye;
    public LayerMask buildLayer;
    void Start()
    {
        myCharacter = Instantiate(characters[PlayerPrefs.GetInt("Index")], Vector3.zero, Quaternion.identity);
        eye = myCharacter.transform.GetChild(myCharacter.transform.childCount - 1).gameObject;
    }
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(eye.transform.position, eye.transform.forward, out hit, 3, buildLayer))
        {
            interactebale.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.OpenURL("https://www.spatial.io/");
                PlayerPrefs.SetInt("BuildIndex", Convert.ToInt32(hit.transform.name));
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        else
        {
            interactebale.SetActive(false);
        }
        Debug.DrawRay(eye.transform.position, eye.transform.forward * 3, Color.red);
    }
}

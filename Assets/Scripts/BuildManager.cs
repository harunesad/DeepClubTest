using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildManager : MonoBehaviour
{
    [SerializeField] List<GameObject> builds;
    [SerializeField] List<GameObject> characters;
    public GameObject interactebale;
    GameObject myCharacter;
    GameObject myBuild, point;
    public GameObject eye;
    public LayerMask sceneLayer;
    void Start()
    {
        myBuild = Instantiate(builds[PlayerPrefs.GetInt("BuildIndex")], Vector3.zero , Quaternion.identity);
        myBuild.transform.localScale = new Vector3(1, 1, 1);
        myBuild.layer = 0;
        myBuild.transform.GetChild(1).gameObject.layer = 0;
        point = myBuild.transform.GetChild(0).gameObject;
        myCharacter = Instantiate(characters[PlayerPrefs.GetInt("Index")], point.transform.position + (Vector3.up * .1f), Quaternion.identity);
        eye = myCharacter.transform.GetChild(myCharacter.transform.childCount - 1).gameObject;
    }
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(eye.transform.position, eye.transform.forward, out hit, 3, sceneLayer))
        {
            interactebale.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(1);
            }
        }
        else
        {
            interactebale.SetActive(false);
        }
        Debug.DrawRay(eye.transform.position, eye.transform.forward * 3, Color.red);
    }
}

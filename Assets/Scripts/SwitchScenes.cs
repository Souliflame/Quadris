﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public string[] sceneNames = new string[1];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switchScene();
    }

    void switchScene()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int menuNum = GetComponent<MoveMenu>().menuNum;
            if (menuNum < sceneNames.Length)
            {
                SceneManager.LoadScene(sceneNames[menuNum]);
            }
        }
    }
}

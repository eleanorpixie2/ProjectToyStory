﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{

    //Buttons used in menu
    public Button StartButton1;
    public Button StartButton2;
    public Button ExitButton;
    public Button MenuButton;
    public Button CreditsButton;

    public AudioClip click;
    public AudioSource source;


    // Use this for initialization
    void Start()
    {
        //dont destroy this game object
        DontDestroyOnLoad(this);

        //set default resolution
        Screen.SetResolution(1280, 1024, true);
        //create code for buttons, buttons only work if there is an object attached to it
        if (StartButton1 != null)
        {
            Button btn = StartButton1.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }
        if (StartButton2 != null)
        {
            Button btn = StartButton2.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick5);
        }
        if (ExitButton != null)
        {
            Button btn1 = ExitButton.GetComponent<Button>();
            btn1.onClick.AddListener(TaskOnClick1);
        }
        if (MenuButton != null)
        {
            Button btn2 = MenuButton.GetComponent<Button>();
            btn2.onClick.AddListener(TaskOnClick2);
        }
        if (CreditsButton != null)
        {
            Button btn3 = CreditsButton.GetComponent<Button>();
            btn3.onClick.AddListener(TaskOnClick3);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    //loads instructions
    void TaskOnClick()
    {
        source.PlayOneShot(click, .5f);
        SceneManager.LoadScene("Tutorial");
    }

    //exits game
    void TaskOnClick1()
    {
        source.PlayOneShot(click, .5f);
        Application.Quit();
    }

    //returns to start menu
    void TaskOnClick2()
    {
        source.PlayOneShot(click, .5f);
        SceneManager.LoadScene("StartMenu");
    }

    //loads credits
    void TaskOnClick3()
    {
        source.PlayOneShot(click, .5f);
        SceneManager.LoadScene("Credits");
    }


    //loads game
    public static void TaskOnClick5()
    {
        SceneManager.LoadScene("Level1");
    }


    //loads win scene
    public static void Win()
    {
        SceneManager.LoadScene("Victory");
    }
    //loads gameover scene
    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
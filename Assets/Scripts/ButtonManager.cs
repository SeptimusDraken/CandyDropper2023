using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ButtonManager : MonoBehaviour
{

    // Accessing Text Type
    public TMP_Text buttonText1;
    public TMP_Text buttonText2;


    // To quit the game
    public void doExitGame()
    {
        Application.Quit();
    }

    /*
        // Accessing GameObject
    GameObject button;
    // Hide button after clicked.
    public void Start()
    {
        button = GameObject.Find("Auto");
    }
    public void HideButton()
    {
        button.SetActive(false);
    }
     
    public void IWasClicked()
    {
        Debug.Log("Clicked!");
    }

        // Change text to " "
    public void NewText1()
    {
        buttonText1.text = "";
    }
    Public void NewText2()
    {
        buttonText2.text = "";
    }*/


}

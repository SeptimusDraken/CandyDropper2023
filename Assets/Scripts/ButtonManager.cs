using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ButtonManager : MonoBehaviour
{

    // Accessing text type
    public TMP_Text buttonText;

    //To hide tect after button clicked
    public void NewText()
    {
        buttonText.text = "";
    }

    // To quit the game
    public void doExitGame()
    {
        Application.Quit();
    }


    //Test and unused code
    /*
    
    public TMP_Text buttonText2; 
     
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
    
    Public void NewText2()
    {
        buttonText2.text = "";
    }*/


}

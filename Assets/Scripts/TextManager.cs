using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TextManager : MonoBehaviour
{

    // Accessing Text Type
    public TMP_Text buttonText1;
    public TMP_Text buttonText2;


    // Changing text to " "
    public void NewText1()
    {
        buttonText1.text = "";
    }

    // To quit the game
    public void doExitGame()
    {
        Application.Quit();
    }

    public void IWasClicked()
    {
        Debug.Log("Clicked!");
    }

    /*/public void NewText2()
    {
        buttonText2.text = "";
    }*/


}

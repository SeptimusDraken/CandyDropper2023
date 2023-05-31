using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Manager1 : MonoBehaviour
{
    // Text Counter
    float TotalClicks;

    // Upgrades
    bool hasUpgrade;
    public int autoClicksPerSecond;
    public int minimumClicksToUnlock;

    // Accessing Text Type
    public TMP_Text upgradeCost;
    public TMP_Text ClicksTotalText;
    public TMP_Text buttonText1;
    public TMP_Text buttonText2;


    public void Start()
    {
        upgradeCost.text = minimumClicksToUnlock.ToString() + " Candies";
    }

    // Total Clicks Display
    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = TotalClicks.ToString("0");
    }


    // Upgrading Module
    public void AutioClickUpgrade()
    {
        if (!hasUpgrade && TotalClicks >= minimumClicksToUnlock)
        {
            TotalClicks -= minimumClicksToUnlock;
            hasUpgrade = true;

        }
    }


    // Upgrade Type
    private void Update()
    {
        if (hasUpgrade)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime;

            ClicksTotalText.text = TotalClicks.ToString("0");
        }
    }


    // Changing text to " "
    public void NewText1()
    {
        buttonText1.text = "";
    }
    public void NewText2()
    {
        buttonText2.text = "";
    }


}

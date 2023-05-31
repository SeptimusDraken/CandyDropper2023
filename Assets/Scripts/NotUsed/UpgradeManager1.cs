using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UpgradeManager1 : MonoBehaviour
{
    public TMP_Text clicksTotalText;
    public TMP_Text upgradeCostA;
    public TMP_Text upgradeCostM;

    float totalClicks;
    bool hasUpgrade;

    public int minimumClicksToUnlock;
    public int autoClicksPerSecond;
    public int spawnCount = 0;
    public int spawnMultiplier = 1;



    void Start()
    {
        //IncreaseSpawnMultiplier(2);
        upgradeCostA.text = minimumClicksToUnlock.ToString() + " Candies";
        upgradeCostM.text = minimumClicksToUnlock.ToString() + " Candies";

    }

    void Update()
    {
        if (!hasUpgrade && spawnCount >= minimumClicksToUnlock)
        {
            spawnCount -= minimumClicksToUnlock;
            hasUpgrade = true;
        }

        if (hasUpgrade)
        {
            totalClicks += autoClicksPerSecond * Time.deltaTime;

            clicksTotalText.text = totalClicks.ToString("0");
        }
    }
    public void AutioClickUpgrade()
    {
        if (!hasUpgrade && totalClicks >= minimumClicksToUnlock)
        {
            totalClicks -= minimumClicksToUnlock;
            hasUpgrade = true;

        }
    }

}

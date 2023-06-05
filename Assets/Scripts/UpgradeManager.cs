using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UpgradeManager : MonoBehaviour
{
    // Accessing text type
    public TMP_Text clicksTotalText;
    public TMP_Text upgradeCostA;
    public TMP_Text upgradeCostM;

    // Variables
    float spawnCount;
    bool hasUpgradeA; 
    bool hasUpgradeM;


    // Intergers
    public int minimumClicksToUnlock;
    public int autoClicksPerSecond;
    public int spawnMultiplier = 1;
    public int upgradeCostIncrease;


    // Object identification and spawn location
    public GameObject spawnPrefab;
    public Transform parentObject;
    public GameObject button1;
    public GameObject button2;

    // To show the cost of the upgrade
    // To access the specific game object buttons
    // Hide upgrade button
    void Start()
    {
        upgradeCostA.text = minimumClicksToUnlock.ToString() + " Candies";
        button1 = GameObject.Find("Auto");
        button2 = GameObject.Find("Multi");
        button2.SetActive(false);
    }

    // Auto clicker per tick
    void Update()
    {
        if (hasUpgradeA)
        {
            spawnCount += autoClicksPerSecond * Time.deltaTime;
            clicksTotalText.text = spawnCount.ToString("0");
        }
        // To show the cost of the upgrade
        upgradeCostM.text = minimumClicksToUnlock.ToString() + " Candies";

        // Show upgrade button after other upgrade clicked
        if (hasUpgradeA == true)
        {
            button2.SetActive(true);
        }
    }

    // Upgrade cost to decrease the total candies
    public void AutoClickUpgrade()
    {
        if (!hasUpgradeA && spawnCount >= minimumClicksToUnlock)
        {
            spawnCount -= minimumClicksToUnlock;
            hasUpgradeA = true;
            // Hide button after clicked
            button1.SetActive(false);
        }
    }

    // Upgrade cost to decrease the total candies
    public void MultiClickUpgrade()
    {
        if (!hasUpgradeM && spawnCount >= minimumClicksToUnlock)
        {
            spawnCount -= minimumClicksToUnlock;
            hasUpgradeM = true;
        }
    }

    // Increase candy cost for upgrade
    public void IncreaseUpgradeCost(int increaseBy)
    {
        minimumClicksToUnlock += increaseBy;
    }


    // Object multiplier
    public void IncreaseSpawnMultiplier(int increaseBy)
    {
        spawnMultiplier += increaseBy;
    }

    // Object multiplier + 1
    public void SpawnMultipleObjects()
    {
        int count = 0;
        while (count < spawnMultiplier)
        {
            count += 1;
            SpawnObject();
        }
    }

    // Spawn objects
    public void SpawnObject()
    {
        Instantiate(spawnPrefab, parentObject.position, Quaternion.identity, parentObject);
        spawnCount++;

        if (clicksTotalText != null)
        {
            clicksTotalText.text = spawnCount.ToString();
        }
    }

}

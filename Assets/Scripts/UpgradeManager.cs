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


    // Object identification and spawn location
    public GameObject spawnPrefab;
    public Transform parentObject;


    void Start()
    {
        upgradeCostA.text = minimumClicksToUnlock.ToString() + " Candies";
        upgradeCostM.text = minimumClicksToUnlock.ToString() + " Candies";
    }

    // Auto clicker per tick
    void Update()
    {
        if (hasUpgradeA)
        {
            spawnCount += autoClicksPerSecond * Time.deltaTime;
            clicksTotalText.text = spawnCount.ToString("0");
        }
    }

    // Upgrade cost
    public void AutoClickUpgrade()
    {
        if (!hasUpgradeA && spawnCount >= minimumClicksToUnlock)
        {
            spawnCount -= minimumClicksToUnlock;
            hasUpgradeA = true;
        }
    }

    public void MultiClickUpgrade()
    {
        if (!hasUpgradeM && spawnCount >= minimumClicksToUnlock)
        {
            spawnCount -= minimumClicksToUnlock;
            hasUpgradeM = true;
        }

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

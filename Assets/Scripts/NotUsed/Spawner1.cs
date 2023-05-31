using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Spawner1 : MonoBehaviour
{
    // Counter Text and Upgrades
    public TMP_Text clicksTotalText;
    public TMP_Text upgradeCost;
    float totalClicks;
    bool hasUpgrade;
    public int minimumClicksToUnlock;


    // Spawners
    public int spawnCount = 0;
    public int spawnMultiplier = 1;

    // Object Identification and Spawn Location
    public GameObject spawnPrefab;
    public Transform parentObject;


    // Void Start Tester
    void Start()
    {
        //IncreaseSpawnMultiplier(2);
        upgradeCost.text = minimumClicksToUnlock.ToString() + " Candies";

    }


    // Object Multiplier
    public void IncreaseSpawnMultiplier(int increaseBy)
    {
        spawnMultiplier += increaseBy;
    }


    // Object Multiplier + 1
    public void SpawnMultipleObjects()
    {
        int count = 0;
        while (count < spawnMultiplier)
        {
            count += 1;
            SpawnObject();
        }
    }


    // Spawn Objects
    public void SpawnObject()
    {
        Instantiate(spawnPrefab, parentObject.position, Quaternion.identity, parentObject);
        spawnCount++;

        if (clicksTotalText != null)
        {
            clicksTotalText.text = spawnCount.ToString();
        }
    }


    // Upgrading Module
    public void MultiClickUpgrade()
    {
        if (!hasUpgrade && spawnCount >= minimumClicksToUnlock)
        {
            spawnCount -= minimumClicksToUnlock;
            hasUpgrade = true;
        }

    }

}

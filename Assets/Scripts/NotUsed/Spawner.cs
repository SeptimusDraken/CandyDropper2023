using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Spawner : MonoBehaviour
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




}

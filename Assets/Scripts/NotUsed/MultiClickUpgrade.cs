using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiClickUpgrade : MonoBehaviour
{

    public GameObject mButton;
    


    void Start()
    {
        mButton = GameObject.Find("Multi2");
        mButton.SetActive(false);
    }

}

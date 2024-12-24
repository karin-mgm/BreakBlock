using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIscript : MonoBehaviour
{
    private int buffer = 0;
    private GameObject clearText;

    // Start is called before the first frame update
    void Start()
    {
        this.clearText = GameObject.Find("clearTxt");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("blockTag").Length == 0)
        {
            Debug.Log("block0");
            if (buffer == 0)
            {
                this.clearText.GetComponent<Text>().text = "CLEAR!!";
            }
            buffer++;

            if (buffer > 700)
            {
                Destroy(this.clearText);
            }
        }

    }
}

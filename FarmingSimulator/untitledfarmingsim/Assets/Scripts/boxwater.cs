﻿/* 
 * boxwater.cs
 * Written by : Toby Klauder
 * Last Edited : 1/21/20
 * Description: using the water bucket, refilling the bucket and changing the bucket texture. 
 * */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class boxwater : MonoBehaviour
{
    public Sprite fullbucket;
    public Sprite notfullbucket; 
    public Button waterbucket;
    public Text watertimer;
    public double time;
    public bool runtimer;
    public bool enableuse; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timecontrol.goddamntheyusedthebucket) {
            waterbucket.GetComponent<Image>().sprite = notfullbucket;
            enableuse = false;
            time = 0; 
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            runtimer = true;
            time++; 
        }

        if (runtimer == true) {
            time += Time.deltaTime; 
        }

        if (time > 30) {
            waterbucket.GetComponent<Image>().sprite = fullbucket;
            enableuse = true;
            time = 0;
            runtimer = false; 
        }

        if (30 - time > 0) {
            watertimer.text = "bucket full in : " + ((int)(30 - time)).ToString() + " seconds.";
        }
    }

    public void OnMouseDown()
    {
        if (waterbucket.GetComponent<Image>().sprite == notfullbucket) {
            Gamemanager.hand = "water bucket"; 
        }
        if (waterbucket.GetComponent<Image>().sprite == fullbucket) {
            Gamemanager.hand = "water bucket full"; 
        }
    }
}

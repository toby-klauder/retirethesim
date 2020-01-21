﻿/* Texttime.cs
 * Written by: Toby Klauder
 * Last Edited: 1/21/20
 * Description: handles changing the last action text
 * */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Texttime : MonoBehaviour
{
    public static string lastactiontext = "Last Action: ";
    public Text lastaction; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lastaction.text = lastactiontext; 
    }
}

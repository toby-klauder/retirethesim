﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickuptool : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(string tooltoequip) {
        Gamemanager.hand = tooltoequip;
        Debug.Log(Gamemanager.hand); 
    }
}

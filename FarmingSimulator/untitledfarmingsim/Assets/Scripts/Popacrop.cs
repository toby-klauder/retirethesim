﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popacrop : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() {
       
        if (Gamemanager.hand == "scythe") {
            Destroy(gameObject); 
        }
    }
}

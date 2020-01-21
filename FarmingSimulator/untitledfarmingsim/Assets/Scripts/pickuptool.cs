/* pickuptool.cs
 * Written by: Toby Klauder
 * Last Edited: 1/21/20
 * Description: equips the tools and packets of seeds for use to the hand slot in the Gamemanager
 * */

using System.Collections;
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
        Texttime.lastactiontext = "Equipped: " + tooltoequip;
    }
}

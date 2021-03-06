﻿/* Popacrop.cs
 * Written by: Toby Klauder
 * Last Edited: 1/21/20
 * Description: when crop is harvested, this runs and provides either money, dirt and crop(s)
 * */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popacrop : MonoBehaviour
{
    int gemchance;
    int chance;
    public System.Random nextnum = new System.Random(); 
    // Start is called before the first frame update
    void Start()
    {
        chance = nextnum.Next(3);
        gemchance = nextnum.Next(50); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() {

            //when click on object, if using scythe then remove and print to lastaction.
            if (Gamemanager.hand == "scythe")
            {
                Destroy(gameObject);
                chance = nextnum.Next(3);
                gemchance = nextnum.Next(50);
                print("chance happened: " + chance.ToString());
                if (chance == 0)
                {
                    Texttime.lastactiontext = "harvested 3 crops";
                    if (gameObject.tag == "wheat")
                    {
                        print(chance.ToString() + "3 wheat");
                        Gamemanager.wheat += 3;
                    }
                    if (gameObject.tag == "corn") {
                        print(chance.ToString() + "3 corn");
                        Gamemanager.corn += 3; 
                    }
                    if (gameObject.tag == "barley") {
                        Gamemanager.barley += 3; 
                    }
                    if (gameObject.tag == "potato") {
                        Gamemanager.potato += 3; 
                    }
                if (gameObject.tag == "carrot") {
                    Gamemanager.carrot += 3; 
                }

                }
                else if (chance == 1)
                {
                Texttime.lastactiontext = "harvested 2 crops"; 
                if (gameObject.tag == "wheat")
                    {
                    print(chance.ToString() + "2 wheat");
                    Gamemanager.wheat += 2;
                    }
                if (gameObject.tag == "corn") {
                    print(chance.ToString() + "2 corn");
                    Gamemanager.corn += 2; 
                }
                if (gameObject.tag == "barley") {
                    Gamemanager.barley += 2; 
                }
                if (gameObject.tag == "potato") {
                    Gamemanager.potato += 2; 
                }
                if (gameObject.tag == "carrot") {
                    Gamemanager.carrot += 2;
                }
                }
                else if (chance == 2)
                {
                Texttime.lastactiontext = "harvested a crop"; 
                    if (gameObject.tag == "wheat")
                    {
                    print(chance.ToString() + "1 wheat");
                    Gamemanager.wheat += 1;
                    }
                    if (gameObject.tag == "corn") {
                    print(chance.ToString() + " corn");
                    Gamemanager.corn += 1; 
                    }
                if (gameObject.tag == "barley") {
                    Gamemanager.barley += 1; 
                }
                if (gameObject.tag == "potato") {
                    Gamemanager.potato += 1; 
                }
                if (gameObject.tag == "carrot") {
                    Gamemanager.carrot += 1; 
                }
                }

                if (gemchance == 0)
                {
                    Texttime.lastactiontext = "found a piece of bronze +100$";
                    Gamemanager.money += 100;
                }
                else if (gemchance == 10)
                {
                    Texttime.lastactiontext = "found a piece of silver +200$";
                    Gamemanager.money += 200;
                }
                else if (gemchance == 20)
                {
                    Texttime.lastactiontext = "found a ruby +300$";
                    Gamemanager.money += 300;
                }
                else if (gemchance == 30)
                {
                    Texttime.lastactiontext = "found a piece of gold +400$";
                    Gamemanager.money += 400;
                }
                else if (gemchance == 40)
                {
                    Texttime.lastactiontext = "found a diamond +500$";
                    Gamemanager.money += 500;
                }
                else
                {
                    Texttime.lastactiontext = "found dirt.";
                }
            }
        }
    }

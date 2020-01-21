/* Gamemanager.cs
 * Written by: Toby Klauder
 * Last Edited: 1/21/20
 * Description: Handles all the stuff.
 * */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static int wheat;
    public static int money = 100;
    public static int barley;
    public static int corn;
    public static int potato;
    public static int carrot;
    public static int seed_wheat = 10;
    public static int seed_barley = 5;
    public static int seed_corn = 5;
    public static int seed_potato = 5;
    public static int seed_carrot = 5;  
    public static string hand = "none";
    internal static string lastactiontext;
    private static Gamemanager _instance;

    public static Gamemanager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Gamemanager>();
                DontDestroyOnLoad(_instance);
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else if(_instance != this)
        {
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (money > 1000000) {
            ChangeScene.changeSceneuni("Main Menu"); 
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static int wheat;
    public static int money;
    public static int barley;
    public static int corn;
    public static int potato;
    public static int carrot;
    public static int seed_wheat = 10;
    public static int seed_barley;
    public static int seed_corn;
    public static int seed_potato;
    public static int seed_carrot;  
    public static string hand = "none";

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

    }
}

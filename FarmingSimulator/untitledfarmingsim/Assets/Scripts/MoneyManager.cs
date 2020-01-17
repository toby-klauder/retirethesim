using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "$" + Gamemanager.money;
    }

    public void purchase(string crop, int cost)
    {
        if(Gamemanager.money >= cost)
        {
            Gamemanager.money -= cost;
        }
      
    }

    public void sell(string crop, int cost)
    {
        Gamemanager.money += cost;
    }
}

/* MoneyManager.cs
 * Written by: Adeline Braun
 * Last Edited: 1/21/20
 * Description: handles the precious green cash
 * */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public Text txt;
    public int wheatBuyCost;
    public int wheatSellCost;
    public int barleyBuyCost;
    public int barleySellCost;
    public int cornBuyCost;
    public int cornSellCost;
    public int potatoBuyCost;
    public int potatoSellCost;
    public int carrotBuyCost;
    public int carrotSellCost;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       txt.text = "$" + Gamemanager.money;
    }

    public void purchase(string crop)
    {

            if (crop.Equals("seed_wheat") && Gamemanager.money >= wheatBuyCost)
            {
                Gamemanager.seed_wheat += 1;
                Gamemanager.money -= wheatBuyCost;
            }
            else if (crop.Equals("seed_barley") && Gamemanager.money >= barleyBuyCost)
            {
                Gamemanager.seed_barley += 1;
                Gamemanager.money -= barleyBuyCost;
            }
            else if (crop.Equals("seed_corn") && Gamemanager.money >= cornBuyCost)
            {
                Gamemanager.seed_corn += 1;
                Gamemanager.money -= cornBuyCost;
            }
            else if (crop.Equals("seed_potato") && Gamemanager.money >= potatoBuyCost)
            {
                Gamemanager.seed_potato += 1;
                Gamemanager.money -= potatoBuyCost;
            }
            else if (crop.Equals("seed_carrot") && Gamemanager.money >= carrotBuyCost)
            {
                Gamemanager.seed_carrot += 1;
                Gamemanager.money -= carrotBuyCost;
            }
        Gamemanager.carrot += 10;
        return;
      
    }


    public void sell(string crop)
    {
        if (crop.Equals("wheat") && Gamemanager.wheat > 0)
        {
            Gamemanager.wheat -= 1;
            Gamemanager.money += wheatSellCost;

        }
        else if (crop.Equals("barley") && Gamemanager.barley > 0)
        {
            Gamemanager.barley -= 1;
            Gamemanager.money += barleySellCost;
        }
        else if (crop.Equals("corn") && Gamemanager.corn > 0)
        {
            Gamemanager.corn -= 1;
            Gamemanager.money += cornSellCost;
        }
        else if (crop.Equals("potato") && Gamemanager.potato > 0)
        {
            Gamemanager.seed_potato -= 1;
            Gamemanager.money += potatoSellCost;
        }
        else if (crop.Equals("carrot") && Gamemanager.carrot > 0)
        {
            Gamemanager.carrot -= 1;
            Gamemanager.money += carrotSellCost;
        }
        return;
    }
}

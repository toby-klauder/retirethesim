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
            if (crop.Equals("wheat") && Gamemanager.money >= wheatBuyCost)
            {
                Gamemanager.seed_wheat += 1;
                Gamemanager.money -= wheatBuyCost;
            }
            else if (crop.Equals("barley") && Gamemanager.money >= barleyBuyCost)
            {
                Gamemanager.seed_barley += 1;
                Gamemanager.money -= barleyBuyCost;
            }
            else if (crop.Equals("corn") && Gamemanager.money >= cornBuyCost)
            {
                Gamemanager.seed_corn += 1;
                Gamemanager.money -= cornBuyCost;
            }
            else if (crop.Equals("potato") && Gamemanager.money >= potatoBuyCost)
            {
                Gamemanager.seed_potato += 1;
                Gamemanager.money -= potatoBuyCost;
            }
            else if (crop.Equals("carrot") && Gamemanager.money >= carrotBuyCost)
            {
                Gamemanager.seed_carrot = +1;
                Gamemanager.money -= carrotBuyCost;
            }
        
      
    }


    public void sell(string crop)
    {
        if (crop.Equals("wheat") && Gamemanager.seed_wheat > 0)
        {
            Gamemanager.seed_wheat -= 1;
            Gamemanager.money += wheatSellCost;

        }
        else if (crop.Equals("barley") && Gamemanager.seed_barley > 0)
        {
            Gamemanager.seed_barley -= 1;
            Gamemanager.money += barleySellCost;
        }
        else if (crop.Equals("corn") && Gamemanager.seed_corn > 0)
        {
            Gamemanager.seed_corn -= 1;
            Gamemanager.money += cornSellCost;
        }
        else if (crop.Equals("potato") && Gamemanager.seed_potato > 0)
        {
            Gamemanager.seed_potato -= 1;
            Gamemanager.money += potatoSellCost;
        }
        else if (crop.Equals("carrot") && Gamemanager.seed_carrot > 0)
        {
            Gamemanager.seed_carrot -= 1;
            Gamemanager.money += carrotSellCost;
        }
    }
}

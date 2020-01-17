using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class numberdisplays : MonoBehaviour
{
    public Text numberdisplay;
    public string type; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(type == "wheat")
        {
            numberdisplay.text = Gamemanager.seed_wheat.ToString(); 
        }
        if (type == "potato") {
            numberdisplay.text = Gamemanager.seed_potato.ToString(); 
        }
        if (type == "barley") {
            numberdisplay.text = Gamemanager.seed_barley.ToString(); 
        }
        if (type == "corn") {
            numberdisplay.text = Gamemanager.seed_corn.ToString(); 
        }
        if (type == "carrot") {
            numberdisplay.text = Gamemanager.seed_carrot.ToString(); 
        }
        if (type == "wheatsilo") {
            numberdisplay.text = "Wheat: " + Gamemanager.wheat.ToString(); 
        }
        if (type == "potatosilo") {
            numberdisplay.text = "Potato: " + Gamemanager.potato.ToString(); 
        }
        if (type == "barleysilo") {
            numberdisplay.text = "Barley: " + Gamemanager.barley.ToString(); 
        }
        if (type == "cornsilo") {
            numberdisplay.text = "Corn: " + Gamemanager.corn.ToString(); 
        }
        if (type == "carrotsilo") {
            numberdisplay.text = "Strawberry: " + Gamemanager.carrot.ToString(); 
        }
    }
}

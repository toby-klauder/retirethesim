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
        if (type == "wheatseed") {
            numberdisplay.text = Gamemanager.seed_wheat.ToString();
        }
        if (type == "barleyseed")
        {
            numberdisplay.text = Gamemanager.seed_barley.ToString();
        }
        if (type == "cornseed")
        {
            numberdisplay.text = Gamemanager.seed_corn.ToString();
        }
        if (type == "potatoseed")
        {
            numberdisplay.text = Gamemanager.seed_potato.ToString();
        }
        if (type == "carrotseed")
        {
            numberdisplay.text = Gamemanager.seed_carrot.ToString();
        }
        if (type == "wheatstore")
        {
            numberdisplay.text = Gamemanager.wheat.ToString();
        }
        if (type == "barleystore")
        {
            numberdisplay.text = Gamemanager.barley.ToString();
        }
        if (type == "cornstore")
        {
            numberdisplay.text = Gamemanager.corn.ToString();
        }
        if (type == "potatostore")
        {
            numberdisplay.text = Gamemanager.potato.ToString();
        }
        if (type == "carrotstore")
        {
            numberdisplay.text = Gamemanager.carrot.ToString();
        }
    }
}

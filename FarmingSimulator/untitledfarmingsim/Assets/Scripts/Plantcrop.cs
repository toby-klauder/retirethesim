/* plantcrop.sc
 * Written by: Toby Klauder
 * Last Edited: 1/21/20
 * Description: low-key self explanitory
 * */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantcrop : MonoBehaviour
{
    public GameObject wheat;
    public GameObject corn;
    public GameObject potato;
    public GameObject barley;
    public GameObject carrot; 
    public bool hascrop;
    public Vector3 brb;
    public Vector3 brbb;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (Gamemanager.hand == "wheat seed" && Gamemanager.seed_wheat > 0) {
            Instantiate(wheat, transform.position, transform.rotation);
            Texttime.lastactiontext = "planted wheat";
            Gamemanager.seed_wheat--; 
            hascrop = true; 
        }
        if (Gamemanager.hand == "corn seed" && Gamemanager.seed_corn > 0) {
            Instantiate(corn, transform.position, transform.rotation);
            Texttime.lastactiontext = "planted corn";
            Gamemanager.seed_corn--;
            hascrop = true; 
        }
        if (Gamemanager.hand == "potato seed" && Gamemanager.seed_potato > 0) {
            Instantiate(potato, transform.position, transform.rotation);
            Texttime.lastactiontext = "planted potato";
            Gamemanager.seed_potato--;
            hascrop = true; 
        }
        if (Gamemanager.hand == "barley seed" && Gamemanager.seed_barley > 0) {
            Instantiate(barley, transform.position, transform.rotation);
            Texttime.lastactiontext = "planted barley";
            Gamemanager.seed_barley--;
            hascrop = true; 
        }
        if (Gamemanager.hand == "carrot seed" && Gamemanager.seed_carrot > 0) {
            Instantiate(carrot, transform.position, transform.rotation);
            Texttime.lastactiontext = "planted strawberry";
            Gamemanager.seed_carrot--;
            hascrop = true; 
        }
        
    }
}

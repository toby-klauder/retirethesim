using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantcrop : MonoBehaviour
{
    public GameObject wheat;
    public bool hascrop;
    public Vector3 brb; 
    // Start is called before the first frame update
    void Start()
    {
        brb = new Vector3(transform.position.x, transform.position.y + 0.35f, transform.position.z); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (Gamemanager.hand == "wheat seed" && Gamemanager.seed_wheat > 0) {
            Instantiate(wheat, brb, transform.rotation);
            Texttime.lastactiontext = "planted wheat";
            Gamemanager.seed_wheat--; 
            hascrop = true; 
        }
        
    }
}

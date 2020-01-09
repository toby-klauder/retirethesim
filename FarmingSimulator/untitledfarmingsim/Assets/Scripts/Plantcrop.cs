using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantcrop : MonoBehaviour
{
    public GameObject wheat;
    public bool hascrop; 
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
        if (!hascrop) {
            Instantiate(wheat, transform.position, transform.rotation);
            hascrop = true; 
        }
        
    }
}

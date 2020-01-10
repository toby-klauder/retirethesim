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
    }
}

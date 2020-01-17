using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timecontrol : MonoBehaviour
{

    public Sprite stageone;
    public Sprite stagetwo;
    public Sprite stagefinal;
    public double growtime;
    public double growthfactor;
    public static bool goddamntheyusedthebucket;
    public bool usebucket; 
    // Start is called before the first frame update
    void Start()
    {
        growthfactor = 1.0; 
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SpriteRenderer>().sprite == stageone || GetComponent<SpriteRenderer>().sprite == stagetwo) {
            growtime += Time.deltaTime * growthfactor;
            GetComponent<SpriteRenderer>().color = Color.red; 
        }
        //grow
        if (growtime > 15) {
            GetComponent<SpriteRenderer>().sprite = stagetwo; 
        }
        if (growtime > 30) {
            GetComponent<SpriteRenderer>().sprite = stagefinal;
            GetComponent<SpriteRenderer>().color = Color.green; 
        }
        goddamntheyusedthebucket = usebucket; 
    }

    public void OnMouseDown()
    {
        if (Gamemanager.hand == "water bucket full") {
            growthfactor = 2.0;
            usebucket = true; 
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timecontrol : MonoBehaviour
{

    public Sprite stageone;
    public Sprite stagetwo;
    public Sprite stagefinal;
    public double growtime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SpriteRenderer>().sprite == stageone || GetComponent<SpriteRenderer>().sprite == stagetwo) {
            growtime += Time.deltaTime; 
        }
        //grow
        if (growtime > 15) {
            GetComponent<SpriteRenderer>().sprite = stagetwo; 
        }
        if (growtime > 30) {
            GetComponent<SpriteRenderer>().sprite = stagefinal; 
        }
    }
}

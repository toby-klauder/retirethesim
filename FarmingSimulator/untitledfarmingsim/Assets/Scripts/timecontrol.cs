using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timecontrol : MonoBehaviour
{

    public Sprite stageone;
    public Sprite stagetwo;
    public Sprite stagefinal;
    public double growtime;
    public static SpriteRenderer swaprender; 
    // Start is called before the first frame update
    void Start()
    {
        swaprender = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (swaprender.sprite == stageone) {
            growtime += Time.deltaTime; 
        }
        //grow
        if (growtime > 15) {
            swaprender.sprite = stagetwo; 
        }
        if (growtime > 30) {
            swaprender.sprite = stagefinal; 
        }
    }
}

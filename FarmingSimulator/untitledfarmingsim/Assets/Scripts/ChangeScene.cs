/* ChangeScene.cs
 * Written by: Adeline Braun
 * Last Edited: 1/21/20
 * Description: handles changing the scene
 * */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public string scene;
    public void changeScene()
    {
        SceneManager.LoadScene(scene);

    }
    public static void changeSceneuni(string scene) {
        SceneManager.LoadScene(scene); 
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneChange : MonoBehaviour
{
    //Gives you a flexible way to change how long the cutscene will take before a level change as well as an option to switch the level to whatever you want
    public float changeTime;
    public string sceneName;

    // Update is called once per frame
    void Update()
    {
        //Ends cutscene by the time you set and goes directly to the level you changed it to
        changeTime -= Time.deltaTime;
        if (changeTime <= 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

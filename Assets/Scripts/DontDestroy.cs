using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    //Kinda confusing but I will try to explain

    //Grabs the instance not to destroy
    public static DontDestroy instance;

    [SerializeField] private AudioSource BGM;

    private void Awake()
    {
        //Destroys the new game object if the original one exists. This means that if a level with BG Music exists, it will destroy the BG Music that is reloaded but not the one that is already loaded
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}

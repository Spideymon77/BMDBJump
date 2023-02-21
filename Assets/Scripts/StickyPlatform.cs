using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    //This one is fucking crazy. It allows the player to move with the moving platform
    
    //Checks if player is on the moving platform
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Sets the player as a parent to the moving platform
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    //Checks if player is off the moving platform
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Unparents player from the moving platform
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}

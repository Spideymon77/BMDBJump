using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sign : MonoBehaviour
{
    //Text displaying the sign
    public GameObject signText;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checks if player is at sign
        if (collision.gameObject.CompareTag("Player"))
        {
            signText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Checks if player is away from sign
        if (collision.gameObject.CompareTag("Player"))
        {
            signText.SetActive(false);
        }
    }
}

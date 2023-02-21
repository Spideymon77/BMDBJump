using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretsScript : MonoBehaviour
{
    public GameObject secretText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            secretText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            secretText.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}

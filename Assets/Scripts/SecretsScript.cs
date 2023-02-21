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
            StartCoroutine(Example());
        }
    }

    IEnumerator Example()
    {
        secretText.SetActive(true);
        yield return new WaitForSeconds(5);
        secretText.SetActive(false);
        Destroy(gameObject);
    }
}

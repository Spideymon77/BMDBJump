using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecretsScript : MonoBehaviour
{
    public int secrets = 0;

    public GameObject secretText;

    [SerializeField] private TextMeshProUGUI secretsNumber;
    [SerializeField] private AudioSource secretFound;

    private bool hasPlayed;

    private bool HasPlayed()
    {
        return hasPlayed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && hasPlayed == false)
        {
            StartCoroutine(Example());
        }
    }

    IEnumerator Example()
    {
        hasPlayed = true;
        secrets++;
        secretsNumber.text = "Secrets Found: " + secrets;
        secretFound.Play();
        secretText.SetActive(true);
        yield return new WaitForSeconds(1.849f);
        secretText.SetActive(false);
        Destroy(gameObject);
    }
}

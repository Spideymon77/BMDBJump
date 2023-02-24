using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecretsScript : MonoBehaviour
{
    //Creates a number that will then be added to
    public int secrets = 0;

    //The text displaying "SECRET"
    public GameObject secretText;

    //The text displlaying number of secrets found as well as the music for finding a secret
    [SerializeField] private TextMeshProUGUI secretsNumber;
    [SerializeField] public AudioSource secretFound;

    //A bool that checks if we already got the secret
    private bool hasPlayed;

    //Returns to bool, indicating that the secret has been played
    private bool HasPlayed()
    {
        return hasPlayed;
    }

    //Checks if the player is at the secret and if the secret has been played
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && hasPlayed == false)
        {
            StartCoroutine(Example());
        }
    }

    //The actual secret activating. In order: Activates hasPlayed bool, adds a number to secrets int, displayed how many secrets found in pause menu, plays secret sound, displays text saying "SECRET", waits, erases text displaying "SECRET", destroys the secret
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

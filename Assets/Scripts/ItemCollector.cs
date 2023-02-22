using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    //Text that's changing the score
    private int gems = 0;
    private int highscore = 0;

    //Text displaying the score
    [SerializeField] private TextMeshProUGUI gemsText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    //SFX when collecting items
    [SerializeField] private AudioSource collectionSoundEffect;
    [SerializeField] private AudioSource beerSoundEffect;

     private void OnTriggerEnter2D(Collider2D collision)
    {
        //The Weed variant: 1 point
        if (collision.gameObject.CompareTag("Gem"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            gems++;
            gemsText.text = "Score: " + gems;
            
            PlayerPrefs.SetInt("Highscore", gems);
            PlayerPrefs.GetInt("Highscore");
            UpdateHighScoreText();
        }

        //The Beer variant: 5 points
        if (collision.gameObject.CompareTag("Beer"))
        {
            beerSoundEffect.Play();
            Destroy(collision.gameObject);
            gems++;
            gems++;
            gems++;
            gems++;
            gems++;
            gemsText.text = "Score: " + gems;

            PlayerPrefs.SetInt("Highscore", gems);
            PlayerPrefs.GetInt("Highscore");
            UpdateHighScoreText();
        }
    }

    void CheckHighScore()
    {
        if (gems > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", gems);
        }
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = $"Highscore: {PlayerPrefs.GetInt("Highscore", 0)}";
    }
}

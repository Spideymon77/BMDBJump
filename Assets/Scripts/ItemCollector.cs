using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    //Text that's changing the score
    public int gems = 0;
    public int highscore = 0;

    //Text displaying the score
    [SerializeField] private TextMeshProUGUI gemsText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    //SFX when collecting items
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //The Weed variant: 1 point
        if (collision.gameObject.CompareTag("Gem"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            gems++;
            gemsText.text = "Score: " + gems;
        }

        //The Beer variant: 5 points
        if (collision.gameObject.CompareTag("Beer"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            gems++;
            gems++;
            gems++;
            gems++;
            gems++;
            gemsText.text = "Score: " + gems;
        }

        //Grabs highscore at end of level
        if (collision.gameObject.CompareTag("Finish"))
        {
            highscore = gems;
            highScoreText.text = "Highscore: " + highscore;
        }
    }
}

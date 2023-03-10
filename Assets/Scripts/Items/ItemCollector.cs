using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    //Text that's changing the score
    public int gems = 0;
    public bool tripping = false;
    public float trippingTime;

    //Text displaying the score
    [SerializeField] private TextMeshProUGUI gemsText;

    [SerializeField] private GameObject trippingEffect;

    //SFX when collecting items
    [SerializeField] private AudioSource collectionSoundEffect;
    [SerializeField] private AudioSource beerSoundEffect;
    [SerializeField] public AudioSource shroomSoundEffect;

    void Update()
    {
        //Tells Shroomiez powerup to stop it's effect and it's sound after tripping time <= 0
        if (tripping == true)
        {
            trippingTime -= Time.deltaTime;
            if (trippingTime <= 0)
            {
                shroomSoundEffect.Stop();
                trippingEffect.SetActive(false);
                tripping = false;
            }
        }

        //Sets tripping time to 16 everytime tripping = false, allowing for multiple trips
        if (tripping == false)
        {
            trippingTime = 16;
        }
    }

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

        //Value increases if tripping on Shroomiez
        if (collision.gameObject.CompareTag("Gem") && tripping == true)
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            gems += 4;
            gemsText.text = "Score: " + gems;
        }

        //The Beer variant: 5 points
        if (collision.gameObject.CompareTag("Beer"))
        {
            beerSoundEffect.Play();
            Destroy(collision.gameObject);
            gems += 5;
            gemsText.text = "Score: " + gems;
        }

        //Value increases if tripping on Shroomiez
        if (collision.gameObject.CompareTag("Beer") && tripping == true)
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            gems += 15;
            gemsText.text = "Score: " + gems;
        }

        //The Shroomiez Variant: Powerup items increase value * 5
        {
            if (collision.gameObject.CompareTag("Shroomiez"))
            {
                ActivatePowerUp();
                Destroy(collision.gameObject);
            }
        }
    }

    //Powerup activates setting tripping to true. Plays shroom sound as well
    void ActivatePowerUp()
    {
        tripping = true;
        trippingEffect.SetActive(true);
        shroomSoundEffect.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    //Grabs death animation as well as the the player
    private Animator anim;
    private Rigidbody2D rb;

    //SFX for death sound and joke death sound
    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource jokeSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Activates the line that kills the player
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }

        //Funny joke if you die to easy spike
        if (collision.gameObject.CompareTag("Joke"))
        {
            DieJoke();
        }
    }

    //Actually kills the player
    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    //Bro, how the fuck did you die to this?
    private void DieJoke()
    {
        jokeSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    //Restarts the level as well as score and gem placement, might change later
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

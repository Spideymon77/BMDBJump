using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private ItemCollector itemcollector;

    // Start is called before the first frame update
    private void Start()
    {
        itemcollector = GetComponent<ItemCollector>();
    }

    //Activates the load new screen line if player reaches the finish
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //CompleteLevel();
        }
    }

    //Loads new scene
    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

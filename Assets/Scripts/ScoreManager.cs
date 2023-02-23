using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //KEEP IN MIND itemCollector.gems++;

    ItemCollector itemCollector;

    [SerializeField] private TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Awake()
    {
        itemCollector = GetComponent<ItemCollector>();
        
        if (!PlayerPrefs.HasKey("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", 0);
        }
    }

    void Update()
    {
        CheckHighScore();
        UpdateHighScoreText();
    }

    void CheckHighScore()
    {
        if (itemCollector.gems > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", itemCollector.gems);
        }
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = $"Highscore: {PlayerPrefs.GetInt("Highscore", 0)}";
    }
}

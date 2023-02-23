using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //KEEP IN MIND itemCollector.gems;

    //References item collector script
    ItemCollector itemCollector;

    [SerializeField] private TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Awake()
    {
        //Grabs item collector script
        itemCollector = GetComponent<ItemCollector>();
        
        //If no highscore exists, set the highscore to 0
        if (!PlayerPrefs.HasKey("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", 0);
        }
    }

    //Checks and updates highscore every fucking frame
    void Update()
    {
        CheckHighScore();
        UpdateHighScoreText();
    }

    //Checks if highscore is > gems. If so, sets the highscore to gem count
    void CheckHighScore()
    {

        //NOTICE itemCollector.gems - to grab a script variable, reference the script and put the variable you want to reference. IE, itemCollector.gems or itemCollector.tripping, etc.
        if (itemCollector.gems > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", itemCollector.gems);
        }
    }

    //Displays highscore text
    void UpdateHighScoreText()
    {
        highScoreText.text = $"Highscore: {PlayerPrefs.GetInt("Highscore", 0)}";
    }
}

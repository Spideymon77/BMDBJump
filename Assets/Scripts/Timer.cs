using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;

    public float currentTime;
    public float startingTime;

    bool timerActive = true;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            currentTime += 1 * Time.deltaTime;
            timerText.text = currentTime.ToString("00:00.00");
        }
    }

    public void timerButton()
    {
        timerActive = !timerActive;
    }
}

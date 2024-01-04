using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countdownText;
    [SerializeField] private GameObject GameOverManager;
    
    private float currentTime = 0f;
    private float startingTime = 10f;
    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = "Time: " + currentTime.ToString("0") + " s";
        if (currentTime <= 0)
        {
            currentTime = 0;
            GameOverManager.GetComponent<GameOverManager>().GameOver();
        }
    }
}

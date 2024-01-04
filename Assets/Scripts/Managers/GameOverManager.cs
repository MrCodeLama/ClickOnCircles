using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public int Score;
    
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private SoundManager SoundManager;
    [SerializeField] private ScoreManager ScoreManager;
    [SerializeField] private GameObject SpawnManager;
    [SerializeField] private GameObject Stats;
    [SerializeField] private TextMeshProUGUI ScoreGameOver;
    [SerializeField] private GameObject Canvas;
    
    private void Awake()
    {
        
    }

    public void GameOver()
    {
        //hide everything
        Canvas.GetComponent<CountdownTimer>().enabled = false;
        SpawnManager.GetComponent<SpawnManager>().circles.SetActive(false);
        SoundManager.playGameOver();
        Score = ScoreManager.Score;
        Destroy(ScoreManager);
        Destroy(SpawnManager);
        Stats.SetActive(false);
        
        //show game over screen
        GameOverScreen.SetActive(true);
        ScoreGameOver.text = "Your score: " + Score;
    }
}

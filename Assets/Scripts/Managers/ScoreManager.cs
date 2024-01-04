using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoreText;
    public int Score = 0;
    private void Awake()
    {
        ScoreText.text = 0.ToString();
        
    }
    private void Update()
    {
        ScoreText.text = "Score: " + Score;
        
    }
    
    public void IncrementScore()
    {
        Score++;
    }
    
}

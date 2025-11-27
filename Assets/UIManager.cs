using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //Singleton
    public static UIManager instance;
    public TMP_Text scoreText;
    private int score = 0;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoreText.text = "Score : " + score;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score : " + score;
    }
}

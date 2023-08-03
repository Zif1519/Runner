using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public int playerScore;

    private void Awake()
    {
        I = this;
    }

    private void Start()
    {
        Time.timeScale = 1.0f;
        playerScore = 0;
    }

    public void GameOver()
    {
        Time.timeScale = 0.0f;
    }
}

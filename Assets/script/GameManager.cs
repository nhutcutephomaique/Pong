using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int player1Score, player2Score;
    public ScoreText scoreTextLeft, scoreTextRight;
    public Action onReset;

    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    public void OnScoreZoneReached(int id)
    {
        onReset?.Invoke();
        if (id == 1)
        {
            player1Score++;
        }
        else if (id == 2)
        {
            player2Score++;
        }
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoreTextLeft.SetScore(player1Score);
        scoreTextRight.SetScore(player2Score);
    }
}

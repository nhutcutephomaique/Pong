using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int player1Score, player2Score;
    public ScoreText scoreTextLeft, scoreTextRight;

    public void OnScoreZoneReached(int id)
    {
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

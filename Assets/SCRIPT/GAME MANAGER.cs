using System;
using UnityEngine;

public class GAMEMANAGER : MonoBehaviour
{

    public SCOREUI scoreUI1;
    public SCOREUI scoreUI2;

    int score1 = 0;
    int score2 = 0;


    public void Point(bool isRight)
    {
        BALLMANAGER ballManager = FindFirstObjectByType<BALLMANAGER>();
        if(isRight == true)
        { 
        score1 += 1;
        scoreUI2.UpdateScore(score1);
        ballManager.ResetPosition();
        }
        else
        {
            score2 += 1;
            scoreUI1.UpdateScore(score2);
            ballManager.ResetPosition();
        }


    }
    







}

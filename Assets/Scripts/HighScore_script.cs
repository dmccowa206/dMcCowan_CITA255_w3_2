using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore_script : MonoBehaviour
{
    private int scoreCurrent = 0;
    private int scoreHigh;
    public TextMeshProUGUI scoreCurrent_txt;
    public TextMeshProUGUI scoreHigh_txt;


    // Update is called once per frame
    void Update()
    {
        scoreCurrent_txt.text = "Current Score: " + scoreCurrent;
        scoreHigh_txt.text = "Previous High Score: " + scoreHigh;
    }
    public void clickScoreBtn()
    {
        scoreCurrent++;
    }
    public void clickSaveBtn()
    {
        if(scoreCurrent > scoreHigh)
        {
            scoreHigh = scoreCurrent;
        }
    }
    public void clickResetBtn()
    {
        scoreCurrent = 0;
    }
}

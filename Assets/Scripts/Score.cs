using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public float score;
    public TMP_Text scoretext;
    public TMP_Text scoretext2;
    void Start()
    {
        score = 0;
    }

    public void Bounce()
    {
        score += 500;
    }

    public void Hole()
    {
        score += 5000;
    }

    public void HomeRun()
    {
        score += 50000;
    }

    private void Update()
    {
        scoretext.text = score.ToString();
        scoretext2.text = score.ToString();
    }

}

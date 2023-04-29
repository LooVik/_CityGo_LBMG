using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreChecker : MonoBehaviour
{

    public static ScoreChecker instance;
    public int score;
    public TMP_Text ScoreText;
    public TMP_Text ScoreValue;

    public float delay = 5f;
    private float timeElapsed;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int scores)
    {
        score += scores;
        ScoreValue.text = score.ToString();
    }

    void Update()
    {
        if (score == 10)
        {
            //timeElapsed += Time.deltaTime;
            //if(timeElapsed >= delay)
            //{
                SceneChange();
               // Destroy(gameObject);
            //}
        }
    }

    private void SceneChange()
    {
        SceneManager.LoadScene(3);
    }
}

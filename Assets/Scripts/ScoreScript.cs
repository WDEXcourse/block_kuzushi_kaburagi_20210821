using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int Score;
    public BlockDestroy blockDestroy;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        //Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Score = blockDestroy.ScoreCount;
        ScoreText.text = "Score:" + Score.ToString();

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Score += 1000;
        //}
    }
}

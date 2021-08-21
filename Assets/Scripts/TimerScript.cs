using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//

public class TimerScript : MonoBehaviour
{
    private float Timer;
    public Text TimerText;

    private float num1;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 60;   
    }

    // Update is called once per frame
    void Update()
    {
        num1 = Mathf.Floor(Timer);
        //TimerText.text = "Time:" + num1.ToString();

        if(Timer >= 0)
        {
            TimerText.text = "Time:" + num1.ToString();
            Timer -= Time.deltaTime * 10;
        }

        else if(Timer < 0)
        {
            //Timer = 0;
            TimerText.text = "Time Up!!";
            print("Time Up!!");
            SceneManager.LoadScene("GameOver");
        }
        
    }
}

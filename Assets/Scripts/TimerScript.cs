using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TimerScript : MonoBehaviour {

    public Text timer;

    public float timeForRound=30;
    private static float totalRoundTime;

    public float increment = 0;
    public static bool GameStart = false;
    public  bool TimerStart = false;
    public StatManager Stat;

    private static float timeLeft;

    // Use this for initialization
    void Start () {
        timeLeft = timeForRound;
        totalRoundTime=timeForRound;
    }
	
	// Update is called once per frame
	void Update () {

        if (GameStart)
        {
            Timer();
        }
       
	}

    void Timer()
    {
        increment++;
        if (increment >= 60)
        {
            timeLeft--;
            increment = 0;
        }

        timer.text = timeLeft.ToString();

        if(timeLeft <= 10)
        {
            timer.color = Color.red;
        }

        if (timeLeft <= 0)
        {
            Stat.currentRound++;
            timer.color = Color.black;
            if (Stat.currentRound > 3)
            {
                SceneManagement.Win();
            }
            GameStart = false;
            GetComponent<Image>().Compare();
        }
    }


    public static void ResetTimer()
    {
        timeLeft = totalRoundTime;
    }

}

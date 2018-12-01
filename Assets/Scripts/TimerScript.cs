using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TimerScript : MonoBehaviour {

    public Text timer;
    public float timeForRound=30;
    public float increment = 0;
    public static bool GameStart = false;
    public bool TimerStart = false;
    public StatManager Stat;

    private float timeLeft;

    // Use this for initialization
    void Start () {
        timeLeft = timeForRound;
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

        if (timeLeft <= 0)
        {
            Stat.currentRound++;
            if (Stat.currentRound > 3)
            {
                SceneManagement.Win();
            }
            GetComponent<Image>().Compare();
        }
    }

}

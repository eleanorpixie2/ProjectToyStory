using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TimerScript : MonoBehaviour {

    public Text timer;
    public float timeleft = 60;
    public float increment = 0;
    public bool GameStart = false;
    public bool TimerStart = false;
	// Use this for initialization
	void Start () {
        GameStart = true;
	}
	
	// Update is called once per frame
	void Update () {

        increment++;
        if (increment >= 60)
        {
            timeleft--;
            increment = 0;
        }

        timer.text = timeleft.ToString();

        if (timeleft <= 0)
        {
            SceneManager.LoadScene(0);
        }
	}

}

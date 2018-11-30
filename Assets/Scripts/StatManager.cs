using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour {


    public int player1TotalScore;
    public int player2TotalScore;

    public int currentRound;

	// Use this for initialization
	void Start () {
        player1TotalScore = 0;
        player2TotalScore = 0;
        currentRound = 1;
    }
	
	// Update is called once per frame
	void Update () {

	}
}

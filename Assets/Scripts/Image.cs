using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Image : MonoBehaviour {



    public List<GameObject> combinations;
    public float timeForFlash;

    public ChoiceController Player1;
    public ChoiceController2 Player2;

    public StatManager scores;

    int player1Score;
    int player2Score;

    public Text player1;
    public Text player2;

    public static bool player1Done;
    public static bool player2Done;

    int index;

    // Use this for initialization
    void Start () {

        Player1.gameObject.SetActive(false);
        Player2.gameObject.SetActive(false);
        player1Done = false;
        player2Done = false;
        FlashImage();
    }
	
	// Update is called once per frame
	void Update () {
        player1.text = "Score: " + scores.player1TotalScore;
        player2.text = "Score: " + scores.player2TotalScore;
        if (player1Done && player2Done)
        {
            scores.currentRound++;
            TimerScript.GameStart = false;
            Compare();
            if (scores.currentRound > 3)
            {
                SceneManagement.Win();
            }
            StartCoroutine(Timer());

            FlashImage();
            Player1.player1Choosing = true;
            Player2.player2Choosing = true;
            player1Done = false;
            player2Done = false;
        }
    }

    public void FlashImage()
    {
        Player1.gameObject.SetActive(false);
        Player2.gameObject.SetActive(false);
        index = GetRandomNumber();
        combinations[index].SetActive(true);
        StartCoroutine(Timer());
        
    }


    int GetRandomNumber()
    {
        System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
        return rnd.Next(0, combinations.Count);
    }

    public void Compare()
    {
        Player1.player1Choosing = false;
        Player2.player2Choosing = false;
        //Player 1 comparisions
        if (Player1.GetComponent<BodyParts>().Head.sprite.Equals(combinations[index].GetComponent<BodyParts>().Head.sprite))
        {
            player1Score++;
        }
        if(Player1.GetComponent<BodyParts>().Arms.sprite.Equals(combinations[index].GetComponent<BodyParts>().Arms.sprite))
        {
            player1Score++;
        }
        if (Player1.GetComponent<BodyParts>().Torso.sprite.Equals(combinations[index].GetComponent<BodyParts>().Torso.sprite))
        {
            player1Score++;
        }
        if (Player1.GetComponent<BodyParts>().Legs.sprite.Equals(combinations[index].GetComponent<BodyParts>().Legs.sprite))
        {
            player1Score++;
        }

        //Player 2 comparisions
        if (Player2.GetComponent<BodyParts>().Head.sprite.Equals(combinations[index].GetComponent<BodyParts>().Head.sprite))
        {
            player2Score++;
        }
        if (Player2.GetComponent<BodyParts>().Arms.sprite.Equals(combinations[index].GetComponent<BodyParts>().Arms.sprite))
        {
            player2Score++;
        }
        if (Player2.GetComponent<BodyParts>().Torso.sprite.Equals(combinations[index].GetComponent<BodyParts>().Torso.sprite))
        {
            player2Score++;
        }
        if (Player2.GetComponent<BodyParts>().Legs.sprite.Equals(combinations[index].GetComponent<BodyParts>().Legs.sprite))
        {
            player2Score++;
        }

        //Compare player scores
        //increase player 1 score
        if(player1Score>player2Score)
        {
            scores.player1TotalScore++;
        }
        //increase player 2 score
        else if(player2Score>player1Score)
        {
            scores.player2TotalScore++;
        }
        //increase player 1 and 2 score
        else if(player1Score==player2Score && player1Score!=0 && player2Score!=0)
        {
            scores.player1TotalScore++;
            scores.player2TotalScore++;
        }

        StartCoroutine(Timer());
        //reset for next round
        player1Done = false;
        player2Done = false;
        Player1.ResetChoices1();
        Player2.ResetChoices2();
        FlashImage();
        Player1.player1Choosing = true;
        Player2.player2Choosing = true;

    }

    //timer for flash
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(timeForFlash);
        combinations[index].SetActive(false);
        Player1.gameObject.SetActive(true);
        Player2.gameObject.SetActive(true);
        TimerScript.ResetTimer();
        TimerScript.GameStart = true;
    }
}

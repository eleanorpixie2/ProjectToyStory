using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Image : MonoBehaviour {



    public List<GameObject> combinations;
    public float timeForFlash;

    public ChoiceController Player1;
    public ChoiceController Player2;

    public StatManager scores;

    int player1Score;
    int player2Score;

    int index;

    // Use this for initialization
    void Start () {

        Player1.gameObject.SetActive(false);
        Player2.gameObject.SetActive(false);

        FlashImage();
    }
	
	// Update is called once per frame
	void Update () {
		if(Player1.player1Done&&Player2.player2Done)
        {
            scores.currentRound++;
            Compare();
            if (scores.currentRound>3)
            {
                //game over code here
            }
            StartCoroutine(Timer());

            FlashImage();
            Player1.player1Choosing = false;
            Player2.player2Choosing = false;
            Player1.player1Done = false;
            Player2.player2Done = false;
        }
	}

    public void FlashImage()
    {
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
        //Player 1 comparisions
        if(Player1.GetComponent<BodyParts>().Head.sprite.Equals(combinations[index].GetComponent<BodyParts>().Head.sprite))
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
        FlashImage();
        Player1.player1Choosing = false;
        Player2.player2Choosing = false;
    }

    //timer for flash
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(timeForFlash);
        combinations[index].SetActive(false);
        Player1.gameObject.SetActive(true);
        Player2.gameObject.SetActive(true);
    }
}

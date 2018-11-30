using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceController : MonoBehaviour {

    //Art for each limb
    public List<Sprite> Head;
    public List<Sprite> Arm;
    public List<Sprite> Torso;
    public List<Sprite> Leg;

    //Gameobject for each bodypart
    public GameObject _Head;
    public GameObject _Arm;
    public GameObject _Torso;
    public GameObject _Leg;

    //Head->Torso->Arms->Legs
    List<bool> madeChoice;

    //Which player
    public int playerNum;

    public bool player1Choosing;
    public bool player2Choosing;

    public bool player1Done;
    public bool player2Done;

    // Use this for initialization
    void Start () {
        madeChoice = new List<bool>(4);
        player1Choosing = false;
        player2Choosing = false;
        player1Done=false;
        player2Done=false;
}
	
	// Update is called once per frame
	void Update () {
        //execute code based on which player it is
		if(playerNum==1&&!player1Choosing)
        {
            player1Choosing = true;
            Choose1();
        }
        else if(playerNum==2&&!player2Choosing)
        {
            player2Choosing = true;
            Choose2();
        }
	}

    void Choose1()
    {
        //input for scrolling through choices and selecting
        float playerChoose1 = Input.GetAxis("Player1Choice");
        float playerSelect1 = Input.GetAxis("Player1Select");

        //for each body part scroll through choices and select
        for(int i=0;i<madeChoice.Count;i++)
        {
            //loop until they finialize a selection for the body part
            while(!madeChoice[i])
            {
                int index = 0;
                switch(i)
                {
                    //head
                    case 0:
                        //scroll to the right
                        if(playerChoose1>0 && index!=4)
                        {
                            index++;
                            _Head.GetComponent<SpriteRenderer>().sprite = Head[index];

                        }
                        //scroll to the left
                        else if(playerChoose1 < 0 && index !=0)
                        {
                            index--;
                            _Head.GetComponent<SpriteRenderer>().sprite = Head[index];
                        }
                        //select
                        if(playerSelect1!=0)
                        {
                            madeChoice[i] = true;
                        }
                        break;
                    //torso
                    case 1:
                        if (playerChoose1 > 0 && index != 4)
                        {
                            index++;
                            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index];

                        }
                        else if (playerChoose1 < 0 && index != 0)
                        {
                            index--;
                            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index];
                        }
                        if (playerSelect1 != 0)
                        {
                            madeChoice[i] = true;
                        }
                        break;
                    //arms
                    case 2:
                        if (playerChoose1 > 0 && index != 4)
                        {
                            index++;
                            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index];

                        }
                        else if (playerChoose1 < 0 && index != 0)
                        {
                            index--;
                            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index];
                        }
                        if (playerSelect1 != 0)
                        {
                            madeChoice[i] = true;
                        }
                        break;
                    //legs
                    case 3:
                        if (playerChoose1 > 0 && index != 4)
                        {
                            index++;
                            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index];

                        }
                        else if (playerChoose1 < 0 && index != 0)
                        {
                            index--;
                            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index];
                        }
                        if (playerSelect1 != 0)
                        {
                            madeChoice[i] = true;
                            player1Done = true;
                        }
                        break;

                }
            }
        }
    }

    //player 2's code
    void Choose2()
    {
        float playerChoose2 = Input.GetAxis("Player2Choice");
        float playerSelect2 = Input.GetAxis("Player2Select");

        for (int i = 0; i < madeChoice.Count; i++)
        {
            while (!madeChoice[i])
            {
                int index = 0;
                switch (i)
                {
                    case 0:
                        if (playerChoose2 > 0 && index != 4)
                        {
                            index++;
                            _Head.GetComponent<SpriteRenderer>().sprite = Head[index];

                        }
                        else if (playerChoose2 < 0 && index != 0)
                        {
                            index--;
                            _Head.GetComponent<SpriteRenderer>().sprite = Head[index];
                        }
                        if (playerSelect2 != 0)
                        {
                            madeChoice[i] = true;
                        }
                        break;
                    case 1:
                        if (playerChoose2 > 0 && index != 4)
                        {
                            index++;
                            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index];

                        }
                        else if (playerChoose2 < 0 && index != 0)
                        {
                            index--;
                            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index];
                        }
                        if (playerSelect2 != 0)
                        {
                            madeChoice[i] = true;
                        }
                        break;
                    case 2:
                        if (playerChoose2 > 0 && index != 4)
                        {
                            index++;
                            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index];

                        }
                        else if (playerChoose2 < 0 && index != 0)
                        {
                            index--;
                            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index];
                        }
                        if (playerSelect2 != 0)
                        {
                            madeChoice[i] = true;
                        }
                        break;
                    case 3:
                        if (playerChoose2 > 0 && index != 4)
                        {
                            index++;
                            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index];

                        }
                        else if (playerChoose2 < 0 && index != 0)
                        {
                            index--;
                            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index];
                        }
                        if (playerSelect2 != 0)
                        {
                            player2Done = true;
                            madeChoice[i] = true;
                        }
                        break;

                }
            }
        }
    }
}

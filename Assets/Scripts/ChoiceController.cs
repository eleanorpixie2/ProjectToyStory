using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceController : MonoBehaviour
{

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


    public bool player1Choosing;

    int index1 = 0;

    bool choosing;

    bool selectedHead1 = false;
    bool selectedArms1 = false;
    bool selectedLegs1 = false;
    bool selectedTorso1 = false;

    float playerChoose1;
    bool playerSelect1;

    // Use this for initialization
    void Start()
    {
        player1Choosing = true;
        choosing = true;
    }

    private float prevPlayerSelect1;
    // Update is called once per frame
    void Update()
    {
        playerChoose1 = Input.GetAxis("Player1Choice");
        playerSelect1 = Input.GetKeyDown("joystick 1 button 0");
        //execute code based on which player it is
        if (player1Choosing)
        {
            if(!selectedHead1&&!selectedArms1&&!selectedLegs1&&!selectedTorso1)
            {
                Choose1Head();
                Debug.Log(selectedArms1);

            }
            else if (selectedHead1 && !selectedArms1 && !selectedLegs1 && !selectedTorso1)
            {
                Choose1Arms();
                Debug.Log(selectedArms1);
            }
            else if (selectedHead1 && selectedArms1 && !selectedLegs1 && !selectedTorso1)
            {
                Choose1Torso();
            }
            else if (selectedHead1 && selectedArms1 && !selectedLegs1 && selectedTorso1)
            {
                Choose1Legs();
            }
            else if (selectedHead1 && selectedArms1 && selectedLegs1 && selectedTorso1)
            {
                Image.player1Done = true;
                player1Choosing = false;
                
            }
        }
        
    }

    public void ResetChoices1()
    {
        index1 = 0;
        _Head.GetComponent<SpriteRenderer>().sprite = Head[0];
        _Arm.GetComponent<SpriteRenderer>().sprite = Arm[0];
        _Torso.GetComponent<SpriteRenderer>().sprite = Torso[0];
        _Leg.GetComponent<SpriteRenderer>().sprite = Leg[0];
        selectedHead1 = false;
        selectedArms1 = false;
        selectedLegs1 = false;
        selectedTorso1 = false;
    }


    //player 1's code
    void Choose1Head()
    {

        if (playerChoose1 > 0 && index1 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Head.GetComponent<SpriteRenderer>().sprite = Head[index1];

        }
        else if (playerChoose1 < 0 && index1 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Head.GetComponent<SpriteRenderer>().sprite = Head[index1];
        }
        if (playerSelect1)
        {
                selectedHead1 = true;
        }

    }
    void Choose1Arms()
    {

        if (playerChoose1 > 0 && index1 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index1];

        }
        else if (playerChoose1 < 0 && index1 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index1];
        }
        if (playerSelect1)
        {
                selectedArms1 = true;
        }

    }
    void Choose1Torso()
    {

        if (playerChoose1 > 0 && index1 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index1];

        }
        else if (playerChoose1 < 0 && index1 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index1];
        }
        if (playerSelect1)
        {
                selectedTorso1 = true;

        }



    }
    void Choose1Legs()
    {

        if (playerChoose1 > 0 && index1 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index1];

        }
        else if (playerChoose1 < 0 && index1 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index1];
        }
        if (playerSelect1)
        {

                selectedLegs1 = true;
        }



    }

    void DelayPlus()
    {
        index1++;
        for(float i=10f; i>=0; i-=Time.deltaTime)
        {
            choosing = false;
            Debug.Log(i);
        }
        choosing = true;

    }
    void DelayMinus()
    {
        index1--;
        for (float i = 10f; i >= 0; i -= Time.deltaTime)
        {
            choosing = false;
            Debug.Log(i);
        }
        choosing = true;
    }

}

  


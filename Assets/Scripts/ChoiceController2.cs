using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceController2 : MonoBehaviour {

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


    //Which player
    bool selectedHead2 = false;
    bool selectedArms2 = false;
    bool selectedLegs2 = false;
    bool selectedTorso2 = false;

    float playerChoose2;
    bool playerSelect2;

    public bool player2Choosing;

    bool choosing;

    int index2 = 0;

    // Use this for initialization
    void Start()
    {
        player2Choosing = true;
        choosing = true;
    }

    // Update is called once per frame
    void Update()
    {
        playerChoose2 = Input.GetAxis("Player2Choice");
        playerSelect2 = Input.GetKeyDown("joystick 2 button 0");
        //execute code based on which player it is
        if (player2Choosing)
        {
            if (!selectedHead2 && !selectedArms2 && !selectedLegs2 && !selectedTorso2)
            {
                Choose2Head();
            }
            else if (selectedHead2 && !selectedArms2 && !selectedLegs2 && !selectedTorso2)
            {
                Choose2Arms();
            }
            else if (selectedHead2 && selectedArms2 && !selectedLegs2 && !selectedTorso2)
            {
                Choose2Torso();
            }
            else if (selectedHead2 && selectedArms2 && !selectedLegs2 && selectedTorso2)
            {
                Choose2Legs();
            }
            else if (selectedHead2 && selectedArms2 && selectedLegs2 && selectedTorso2)
            {
                Image.player2Done = true;
                player2Choosing = false;
            }
        }
    }

    public void ResetChoices2()
    {
        index2 = 0;
        _Head.GetComponent<SpriteRenderer>().sprite = Head[0];
        _Arm.GetComponent<SpriteRenderer>().sprite = Arm[0];
        _Torso.GetComponent<SpriteRenderer>().sprite = Torso[0];
        _Leg.GetComponent<SpriteRenderer>().sprite = Leg[0];
        selectedHead2 = false;
        selectedArms2 = false;
        selectedLegs2 = false;
        selectedTorso2 = false;
    }


    bool choice = false;
    //player 2's code
    void Choose2Head()
    {

        if (playerChoose2 > 0 && index2 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Head.GetComponent<SpriteRenderer>().sprite = Head[index2];


        }
        else if (playerChoose2 < 0 && index2 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Head.GetComponent<SpriteRenderer>().sprite = Head[index2];
          
        }
        if (playerSelect2)
        {
            selectedHead2 = true;
        }

    }
    void Choose2Arms()
    {


        if (playerChoose2 > 0 && index2 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index2];

        }
        else if (playerChoose2 < 0 && index2 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index2];
        }
        if (playerSelect2)
        {

            selectedArms2 = true;
        }

    }
    void Choose2Torso()
    {

        if (playerChoose2 > 0 && index2 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index2];

        }
        else if (playerChoose2 < 0 && index2 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index2];
        }
        if (playerSelect2)
        {

            selectedTorso2 = true;

        }



    }
    void Choose2Legs()
    {

        if (playerChoose2 > 0 && index2 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index2];

        }
        else if (playerChoose2 < 0 && index2 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index2];
        }
        if (playerSelect2)
        {

            selectedLegs2 = true;

        }



    }

    void DelayPlus()
    {
        index2++;
        for (float i = 10f; i >= 0; i -= Time.deltaTime)
        {
            choosing = false;
            Debug.Log(i);
        }
        choosing = true;

    }
    void DelayMinus()
    {
        index2--;
        for (float i = 10f; i >= 0; i -= Time.deltaTime)
        {
            choosing = false;
            Debug.Log(i);
        }
        choosing = true;
    }

}

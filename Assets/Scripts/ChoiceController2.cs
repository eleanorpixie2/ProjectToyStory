using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceController2 : MonoBehaviour
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


    public bool player2Choosing;

    int index2 = 0;

    int delay = 25;
    int updateDelay = 0;

    bool choosing;

    bool selectedHead2 = false;
    bool selectedArms2 = false;
    bool selectedLegs2 = false;
    bool selectedTorso2 = false;

    float playerChoose2;
    bool playerSelect2;

    float playerChooseKey2;
    bool playerSelectKey2;

    // Use this for initialization
    void Start()
    {
        player2Choosing = true;
        choosing = true;

    }

    private float prevPlayerSelect2;
    GameObject image;
    // Update is called once per frame
    void Update()
    {
        playerChoose2 = Input.GetAxis("Player2Choice");
        playerSelect2 = Input.GetKeyDown("joystick 2 button 0");
        playerChooseKey2 = Input.GetAxis("Horizontal1");
        playerSelectKey2 = Input.GetKeyDown("left ctrl");
        image = GameObject.FindGameObjectWithTag("Image");

        //execute code based on which player it is
        if (player2Choosing)
        {
            if (image != null)
            {
                image.SetActive(false);
            }
            if (!selectedHead2 && !selectedArms2 && !selectedLegs2 && !selectedTorso2 && choosing)
            {
                Choose2Head();

            }
            else if (selectedHead2 && !selectedArms2 && !selectedLegs2 && !selectedTorso2 && choosing)
            {
                Choose2Arms();
            }
            else if (selectedHead2 && selectedArms2 && !selectedLegs2 && !selectedTorso2 && choosing)
            {
                Choose2Torso();
            }
            else if (selectedHead2 && selectedArms2 && !selectedLegs2 && selectedTorso2 && choosing)
            {
                Choose2Legs();
            }
            else if (!choosing)
            {
                if (updateDelay != delay)
                {
                    updateDelay++;
                }
                else
                {
                    updateDelay = 0;
                    choosing = true;
                }
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


    //player 2's code
    void Choose2Head()
    {

        if (playerChoose2 > 0 || playerChooseKey2 > 0 && index2 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Head.GetComponent<SpriteRenderer>().sprite = Head[index2];

        }
        else if (playerChoose2 < 0 || playerChooseKey2 < 0 && index2 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Head.GetComponent<SpriteRenderer>().sprite = Head[index2];
        }
        if (playerSelect2 || playerSelectKey2)
        {
            selectedHead2 = true;
        }

    }
    void Choose2Arms()
    {

        if (playerChoose2 > 0 || playerChooseKey2 > 0 && index2 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index2];

        }
        else if (playerChoose2 < 0 || playerChooseKey2 < 0 && index2 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Arm.GetComponent<SpriteRenderer>().sprite = Arm[index2];
        }
        if (playerSelect2 || playerSelectKey2)
        {
            selectedArms2 = true;
        }

    }
    void Choose2Torso()
    {

        if (playerChoose2 > 0 || playerChooseKey2 > 0 && index2 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index2];

        }
        else if (playerChoose2 < 0 || playerChooseKey2 < 0 && index2 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Torso.GetComponent<SpriteRenderer>().sprite = Torso[index2];
        }
        if (playerSelect2 || playerSelectKey2)
        {
            selectedTorso2 = true;

        }



    }
    void Choose2Legs()
    {

        if (playerChoose2 > 0 || playerChooseKey2 > 0 && index2 != 5 && choosing)
        {
            choosing = false;
            DelayPlus();
            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index2];

        }
        else if (playerChoose2 < 0 || playerChooseKey2 < 0 && index2 != 0 && choosing)
        {
            choosing = false;
            DelayMinus();
            _Leg.GetComponent<SpriteRenderer>().sprite = Leg[index2];
        }
        if (playerSelect2 || playerSelectKey2)
        {

            selectedLegs2 = true;
        }



    }

    void DelayPlus()
    {
        index2++;


    }
    void DelayMinus()
    {
        index2--;

    }

}




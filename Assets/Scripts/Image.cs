using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Image : MonoBehaviour {

    GameObject[] bodyparts;

    public List<Sprite> Head;
    public List<Sprite> Arm;
    public List<Sprite> Torso;
    public List<Sprite> Leg;

    //Gameobject for each bodypart
    public GameObject _Head;
    public GameObject _Arm;
    public GameObject _Torso;
    public GameObject _Leg;

    public float timeForFlash;

    // Use this for initialization
    void Start () {
        bodyparts = GameObject.FindGameObjectsWithTag("BodyPart");
        foreach(GameObject b in bodyparts)
        {
            b.SetActive(false);
        }

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FlashImage()
    {
        Instantiate(_Head, new Vector3(0, 1), Quaternion.Euler(0, 0, 0));
        Instantiate(_Arm, new Vector3(0, .5f), Quaternion.Euler(0, 0, 0));
        Instantiate(_Torso, new Vector3(0, .5f), Quaternion.Euler(0, 0, 0));
        Instantiate(_Leg, new Vector3(0, 0), Quaternion.Euler(0, 0, 0));
        StartCoroutine(Timer());
        Destroy(_Head);
        Destroy(_Arm);
        Destroy(_Torso);
        Destroy(_Leg);
        foreach (GameObject b in bodyparts)
        {
            b.SetActive(true);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(timeForFlash);
    }
}

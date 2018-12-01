using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Sound : MonoBehaviour
{
    public AudioClip selectMenu;
    private AudioSource source;
    private float vol = .75f;


	void Awake ()
    {
        source = GetComponent<AudioSource>();
	}
	
	void Update ()
    {
        if (Input.GetButtonDown("Select1"))
        {
            source.PlayOneShot(selectMenu, vol);
        }

	}
}

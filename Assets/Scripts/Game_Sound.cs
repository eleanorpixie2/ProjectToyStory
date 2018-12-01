using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    
    public AudioClip selectionToy;
    private AudioSource source;
    public float vol = .75f;


    void Awake ()
    {
        source = GetComponent<AudioSource>();
	}
	
	void Update ()
    {
		if (Input.GetButtonDown("Select1"))
        {
            source.PlayOneShot(selectionToy, vol);
        }
	}

}

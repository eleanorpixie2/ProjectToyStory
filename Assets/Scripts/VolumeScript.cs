using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeScript : MonoBehaviour {

    private AudioSource audioSrc;
    private float musicVolume = 50f;
	// Use this for initialization
	void Start () {
        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        audioSrc.volume = musicVolume;
	}

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}

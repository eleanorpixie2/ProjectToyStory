using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonUI : MonoBehaviour {

    public bool MouseOver = false;
    public bool AudioPlay = false;
    public AudioSource Click;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("MainMenu");
        }
	}


    private void OnMouseOver()
    {
        if (MouseOver == false)
        {
        transform.localScale += new Vector3(0.2f, 0.2f, 0);
        MouseOver = true;
        }
        if (MouseOver == true && AudioPlay == false)
        {
            Click.Play();
            AudioPlay = true;
        }

    }

    private void OnMouseExit()
    {
        transform.localScale -= new Vector3(0.2f, 0.2f, 0);
        MouseOver = false;
        AudioPlay = false;
    }
}

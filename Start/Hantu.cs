using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hantu : MonoBehaviour {


    public AudioSource[] audiosource;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlaySound(AudioClip ac)
    {
        GetComponent<AudioSource>().PlayOneShot(ac);
    }

    public void PlaySoundLocal(int index)
    {
        audiosource[index].Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    public AudioSource soundSource;
    public AudioSource soundSource1;

    // Use this for initialization
    void Start () {
        soundSource.Play();
        soundSource1.Play();
		
	}
	
}

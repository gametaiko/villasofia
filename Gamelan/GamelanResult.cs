using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamelanResult : MonoBehaviour {

    //use score like when you hit things (store something)
    //store string in an array
    //share stored array to another script
    //check array with declared array 

    AudioSource[] gamelanSheet;
    
    public AudioSource gamelan1;
    public AudioSource gamelan2;
    public AudioSource gamelan3;
    public AudioSource gamelan4;
    public AudioSource gamelan5;
    public AudioSource gamelan6;
    public AudioSource gamelan7;
    public AudioSource gamelan8;

    private void Start()
    {
        gamelan1 = GetComponent<AudioSource>();
        gamelan2 = GetComponent<AudioSource>();
        gamelan3 = GetComponent<AudioSource>();
        gamelan4 = GetComponent<AudioSource>();
        gamelan5 = GetComponent<AudioSource>();
        gamelan6 = GetComponent<AudioSource>();
        gamelan7 = GetComponent<AudioSource>();
        gamelan8 = GetComponent<AudioSource>();
    }

    public void GamelanMusicSheet(int index)
    {
        gamelanSheet = new AudioSource[20];

        gamelanSheet[0] = GetComponent<AudioSource>();
        gamelanSheet[1] = GetComponent<AudioSource>();
        gamelanSheet[2] = GetComponent<AudioSource>();
        gamelanSheet[3] = GetComponent<AudioSource>();
        gamelanSheet[4] = GetComponent<AudioSource>();
        gamelanSheet[5] = GetComponent<AudioSource>();
        gamelanSheet[6] = GetComponent<AudioSource>();
        gamelanSheet[7] = GetComponent<AudioSource>();
        gamelanSheet[8] = GetComponent<AudioSource>();
        gamelanSheet[9] = GetComponent<AudioSource>();
        gamelanSheet[10] = GetComponent<AudioSource>();
        gamelanSheet[11] = GetComponent<AudioSource>();
        gamelanSheet[12] = GetComponent<AudioSource>();
        gamelanSheet[13] = GetComponent<AudioSource>();
        gamelanSheet[14] = GetComponent<AudioSource>();
        gamelanSheet[15] = GetComponent<AudioSource>();
        gamelanSheet[16] = GetComponent<AudioSource>();
        gamelanSheet[17] = GetComponent<AudioSource>();
        gamelanSheet[18] = GetComponent<AudioSource>();
        gamelanSheet[19] = GetComponent<AudioSource>();
    }

    public void GamelanTrueorFalse()
    {

    }

    public void ResultGamelan()
    {
        if (gameObject.name == "gamelan0")
        {
            gamelan1.Play();
            print("Gamelan1");
        }

        if (gameObject.name == "gamelan1")
        {
            gamelan2.Play();
            print("Gamelan2");
        }

        if (gameObject.name == "gamelan2")
        {
            gamelan3.Play();

            print("Gamelan3");
        }

        if (gameObject.name == "gamelan3")
        {
            gamelan4.Play();
            print("Gamelan4");
        }

        if (gameObject.name == "gamelan4")
        {
            gamelan5.Play();
            print("Gamelan5");
        }

        if (gameObject.name == "gamelan5")
        {
            gamelan6.Play();
            print("Gamelan6");
        }

        if (gameObject.name == "gamelan6")
        {
            gamelan7.Play();
            print("Gamelan7");
        }

        if (gameObject.name == "gamelan7")
        {
            gamelan8.Play();
            print("Gamelan8");
        }
    }

    
}

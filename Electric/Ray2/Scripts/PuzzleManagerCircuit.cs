using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManagerCircuit : MonoBehaviour {

    string Name1, Name2, color1, color2;
    public GameObject[] test;
    float delay = 3.0f;

    private bool hasFailed = false;

    bool wireRed, wireBlue, wireBlack = false;

    public ParticleSystem sparks;
	
	void Start () {
        Name1 = "";
        color1 = "";
	}
	
    private void OnTriggerEnter(Collider other)
    {
        if(Name1 == "" && color1 == "")
        {
            Name1 = other.gameObject.name;
            color1 = other.gameObject.tag;
        }
        else
        {
            Name2 = other.gameObject.name;
            color2 = other.gameObject.tag;
            CheckIfMatch();
        }

        print(Name1 + color1);
        print(Name2 + color2);
        
    }

    void CheckIfMatch()
    {
        if(Name1 != Name2 && color1 == color2)
        {
            DisableCollider();
            print("Match!");
            Name1 = "";
            color1 = "";
            Name2 = "";
            color2 = "";

        }      
        else if (Name1 == Name2 && color1 == color2)
        {
            print("Same circuit, dumbass.");
            Name1 = "";
            color1 = "";
            Name2 = "";
            color2 = "";
            //dull electric sound or something
        }
        else if(color1 != color2)
        {
            print("Does not match.");
            Name1 = "";
            color1 = "";
            Name2 = "";
            color2 = "";

            //Fail condition
            //hasFailed = true;
            //StartCoroutine(LoseTransitionCountdown(delay));
        }
    }

    void DisableCollider()
    {

        if (color1 == "Red" && color2 == "Red")
        {
            test = GameObject.FindGameObjectsWithTag("Red");
            foreach (GameObject sample in test)
            {
                sample.GetComponent<SphereCollider>().enabled = false;
            }

            GameObject CircuitRed = GameObject.Find("WireRed");
            CircuitRed.GetComponent<Renderer>().enabled = true;
            Instantiate(sparks, transform.position, transform.rotation);
            wireRed = true;
        }

        else if (color1 == "Blue" && color2 == "Blue")
        {
            test = GameObject.FindGameObjectsWithTag("Blue");
            foreach (GameObject sample in test)
            {
                sample.GetComponent<SphereCollider>().enabled = false;
            }

            GameObject CircuitBlue = GameObject.Find("WireBlue");
            CircuitBlue.GetComponent<Renderer>().enabled = true;
            wireBlue = true;
        }

        else if (color1 == "Black" && color2 == "Black")
        {
            test = GameObject.FindGameObjectsWithTag("Black");
            foreach (GameObject sample in test)
            {
                sample.GetComponent<SphereCollider>().enabled = false;
            }

            GameObject CircuitBlack = GameObject.Find("WireBlack");
            CircuitBlack.GetComponent<Renderer>().enabled = true;
            wireBlack = true;
        }
    }


    private void Update()
    {
        if(wireRed && wireBlue && wireBlack == true)
        {
            print("You win!");
            // StartCoroutine(WinTransitionCountdown(delay));
        }
    }


    IEnumerator WinTransitionCountdown(float delay)
    {
        yield return new WaitForSeconds(delay);
        //SceneManager.LoadScene("");
    }

    IEnumerator LoseTransitionCountdown(float delay)
    {
        yield return new WaitForSeconds(delay);
        //SceneManager.LoadScene("");
    }

    //void PlayVoice()
    //{

    //}
}

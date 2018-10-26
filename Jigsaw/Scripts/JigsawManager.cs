using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class JigsawManager : MonoBehaviour {

    public Button btn1, btn2, btn3, btn4;
    public GameObject active1, active2, active3, active4, Wrong1;


    public AudioSource soundSource;
    public AudioSource soundSource1;

    public bool activateme = false;
    public bool isWin = false;


    private void Update()
    {
        CheckActivePieces();
        if(isWin == true)
        {
            print("You WIN!");
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "layer1" && collider.gameObject.tag == "P1")
        {
            if (activateme == false)
            {
                active1.SetActive(false);
            }
            else
            {
                active1.SetActive(true);
                soundSource.Play();
                Destroy(collider.gameObject);
            }

        }
        else if (collider.gameObject.tag == "layer2")
        {
            if (activateme == false)
            {
                active2.SetActive(false);

            }
            else
            {
                active2.SetActive(true);
                soundSource.Play();
                Destroy(collider.gameObject);
            }
            
        }
        else if (collider.gameObject.tag == "layer3")
        {
            if (activateme == false)
            {
                active3.SetActive(false);
            }
            else
            {
                active3.SetActive(true);
                soundSource.Play();
                Destroy(collider.gameObject);
            }
        }
        else if (collider.gameObject.tag == "layer4")
        {
            if (activateme == false)
            {
                active4.SetActive(false);
            }
            else
            {
                active4.SetActive(true);
                soundSource.Play();
                Destroy(collider.gameObject);
            }
        }
        else if (collider.gameObject.tag == "Wrong1")
        {
            //Jumpscare
            if (activateme == false)
            {
                Wrong1.SetActive(false);
            }
            else
            {
                Wrong1.SetActive(true);
                soundSource.Play();
                soundSource1.Play();
                Destroy(collider.gameObject);
                // StartCoroutine("End");
            }
        }
        
    }

    void CheckActivePieces() //winning condition
    {
      
        if (active1.activeInHierarchy == true && active2.activeInHierarchy == true && active3.activeInHierarchy == true && active4.activeInHierarchy == true)
        {
            
            isWin = true;       //if all pieces is active you win
           // StartCoroutine("Wait");
        }
        else
        {
            print("please find more photo");
        }
    }

    //private IEnumerator Wait() //Next scene
    //{
    //    yield return new WaitForSeconds(2.0f);

    //    SceneManager.LoadScene("");

    //}

    //private IEnumerator End()  //End Scene
    //{
    //    yield return new WaitForSeconds(2.0f);

    //    SceneManager.LoadScene("");

    //}
}

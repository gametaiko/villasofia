using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class JigsawManager : MonoBehaviour {

    public Button Pieces1, Pieces2, Pieces3, Pieces4;
    public GameObject layer1, layer2, layer3, layer4, Wrong1, particle;
    public bool activateme = false;

    public AudioSource soundSource;

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
        if (collider.gameObject.tag == "layer1")
        {
            if (activateme == false)
            {
                layer1.SetActive(false);
                particle.SetActive(false);
               
            }
            else
            {
                layer1.SetActive(true);
                particle.SetActive(true);
                soundSource.Play();
                Destroy(collider.gameObject);
            }

        }
        else if (collider.gameObject.tag == "layer2")
        {
            if (activateme == false)
            {
                layer2.SetActive(false);
                particle.SetActive(false);

            }
            else
            {
                layer2.SetActive(true);
                particle.SetActive(true);
                soundSource.Play();
                Destroy(collider.gameObject);
            }
            
        }
        else if (collider.gameObject.tag == "layer3")
        {
            if (activateme == false)
            {
                layer3.SetActive(false);
                particle.SetActive(false);

            }
            else
            {
                layer3.SetActive(true);
                particle.SetActive(true);
                soundSource.Play();
                Destroy(collider.gameObject);
            }
        }
        else if (collider.gameObject.tag == "layer4")
        {
            if (activateme == false)
            {
                layer4.SetActive(false);
                particle.SetActive(false);

            }
            else
            {
                layer4.SetActive(true);
                particle.SetActive(true);
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
                particle.SetActive(false);

            }
            else
            {
                Wrong1.SetActive(true);
                particle.SetActive(true);
                soundSource.Play();
                Destroy(collider.gameObject);
            }
        }
        
    }

    void CheckActivePieces() //winning condition
    {
        //if all pieces is active you win
        if (layer1.activeInHierarchy == true && layer2.activeInHierarchy == true && layer3.activeInHierarchy == true && layer4.activeInHierarchy == true)
        {
            
            isWin = true;//if all pieces is active you win
           // StartCoroutine("Wait");
        }
        else
        {
            print("please find more photo");
        }
    }

    //private IEnumerator Wait()
    //{
    //    yield return new WaitForSeconds(3.0f);

    //    SceneManager.LoadScene("");

    //}
}

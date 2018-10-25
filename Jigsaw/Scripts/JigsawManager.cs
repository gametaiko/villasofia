using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class JigsawManager : MonoBehaviour {

    public Button Pieces1, Pieces2, Pieces3, Pieces4;
    public GameObject layer1, layer2, layer3, layer4;
    public bool activateme = false;

    void Start()
    {
        CheckActivePieces();
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "layer1")
        {
            if (activateme == false)
            {
                layer1.SetActive(false);
                
            }
            else
            {
                layer1.SetActive(true);
                Destroy(collider.gameObject);
            }

        }
        else if (collider.gameObject.tag == "layer2")
        {
            if (activateme == false)
            {
                layer2.SetActive(false);
                
            }
            else
            {
                layer2.SetActive(true);
                Destroy(collider.gameObject);
            }
            
        }
        else if (collider.gameObject.tag == "layer3")
        {
            if (activateme == false)
            {
                layer3.SetActive(false);
                
            }
            else
            {
                layer3.SetActive(true);
                Destroy(collider.gameObject);
            }
        }
        else if (collider.gameObject.tag == "layer4")
        {
            if (activateme == false)
            {
                layer4.SetActive(false);
                
            }
            else
            {
                layer4.SetActive(true);
                Destroy(collider.gameObject);
            }
        }
        else
        {
            //you lose, ghost come closer
        }
        
    }

    void CheckActivePieces() //winning condition
    {
        //if all pieces is active you win
        if (layer1.activeInHierarchy == true && layer2.activeInHierarchy == true && layer3.activeInHierarchy == true && layer4.activeInHierarchy == true)
        {
            print("youWin");//if all pieces is active you win
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

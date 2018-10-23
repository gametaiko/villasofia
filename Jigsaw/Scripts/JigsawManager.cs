using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class JigsawManager : MonoBehaviour {

    public Button Pieces1, Pieces2, Pieces3, Pieces4;
    public GameObject layer1, layer2, layer3, layer4;
    public bool activateme = false;

    void Start()
    {
        //CheckActivePieces();
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "HandTouch")
        {
            if (activateme)
            {
                if (gameObject.tag == "layer1")
                {
                    layer1.SetActive(false);
                }
                else
                {
                    layer1.SetActive(true);
                    Destroy(Pieces1);
                    Debug.Log("Pieces active");
                }
            }
            else if (activateme)
            {
                if (gameObject.tag == "layer2")
                {
                    layer2.SetActive(false);
                }
                else
                {
                    layer2.SetActive(true);
                    Destroy(Pieces2);
                    Debug.Log("Pieces active");
                }
            }
            else if (activateme)
            {
                if (gameObject.tag == "layer3")
                {
                    layer3.SetActive(false);
                }
                else
                {
                    layer3.SetActive(true);
                    Destroy(Pieces3);
                    Debug.Log("Pieces active");
                }
            }
            else if (activateme)
            {
                if (gameObject.tag == "layer4")
                {
                    layer4.SetActive(false);
                }
                else
                {
                    layer4.SetActive(true);
                    Destroy(Pieces4);
                    Debug.Log("Pieces active");
                }
            }
            else
            {
                //you lose, ghost come closer
            }

        }
        
    }

    //void CheckActivePieces()
    //{
    //    //if all pieces is active you win
    //    if(gameObject.tag == "layer1" && gameObject.tag == "layer2" && gameObject.tag == "layer3" && gameObject.tag == "layer4")
    //    {
    //        //if all pieces is active you win
    //        //StartCoroutine("Wait");
    //    }
    //}

    //private IEnumerator Wait()
    //{
    //    yield return new WaitForSeconds(3.0f);

    //    SceneManager.LoadScene("");

    //}
}

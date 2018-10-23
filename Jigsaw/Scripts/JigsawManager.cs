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
    public bool activateme;

    void Start()
    {
        //Button btn1 = Pieces1.GetComponent<Button>();
        //Button btn2 = Pieces2.GetComponent<Button>();
        //Button btn3 = Pieces3.GetComponent<Button>();
        //Button btn4 = Pieces4.GetComponent<Button>();

        //Calls the Task when you click the Button
        //btn1.onClick.AddListener(Button1Task);
        //btn2.onClick.AddListener(Button2Task);
        //btn3.onClick.AddListener(Button3Task);
        //btn4.onClick.AddListener(Button4Task);

        //StartCoroutine("Wait");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "layer1")
        {
            if (activateme == false)
            {
                layer1.SetActive(false);
            }
            else
            {
                layer1.SetActive(true);
            }
        }
       else if (collision.gameObject.tag == "layer2")
        {
            if (activateme == false)
            {
                layer2.SetActive(false);
            }
            else
            {
                layer2.SetActive(true);
            }
        }
        else if (collision.gameObject.tag == "layer3")
        {
            if (activateme == false)
            {
                layer3.SetActive(false);
            }
            else
            {
                layer3.SetActive(true);
            }
        }
        else if (collision.gameObject.tag == "layer4")
        {
            if (activateme == false)
            {
                layer4.SetActive(false);
            }
            else
            {
                layer4.SetActive(true);
            }
        }
        else
        {
            //gameOver
        }
    }

    //void Button1Task()
    //{
    //    if (activateme == false)
    //    {
    //        layer1.SetActive(false);
    //    }
    //    else
    //    {
    //        layer1.SetActive(true);
    //    }

    //}

    //void Button2Task()
    //{
    //    if (activateme == false)
    //    {
    //        layer2.SetActive(false);
    //    }
    //    else
    //    {
    //        layer2.SetActive(true);
    //    }

    //}
    //void Button3Task()
    //{
    //    if (activateme == false)
    //    {
    //        layer3.SetActive(false);
    //    }
    //    else
    //    {
    //        layer3.SetActive(true);
    //    }

    //}
    //void Button4Task()
    //{
    //    if (activateme == false)
    //    {
    //        layer4.SetActive(false);
    //    }
    //    else
    //    {
    //        layer4.SetActive(true);
    //    }
    //}

    //IEnumerator Wait()
    //{
    //    yield return new WaitForSeconds(2.0f);

    //    SceneManager.LoadScene("Room3");
    //}

}

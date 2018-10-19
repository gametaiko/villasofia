using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageOnClick : MonoBehaviour {

    //Make sure to attach these Buttons in the Inspector
    public Button Pieces1, Pieces2, Pieces3, Pieces4;
    public GameObject layer1, layer2, layer3, layer4;
    public bool activateme;

    bool isActive1 = false;
    bool isActive2 = false;
    bool isActive3 = false;
    bool isActive4 = false;


    void Start()
    {
        Button btn1 = Pieces1.GetComponent<Button>();
        Button btn2 = Pieces2.GetComponent<Button>();
        Button btn3 = Pieces3.GetComponent<Button>();
        Button btn4 = Pieces4.GetComponent<Button>();

        //Calls the Task when you click the Button
        btn1.onClick.AddListener(Button1Task);
        btn2.onClick.AddListener(Button2Task);
        btn3.onClick.AddListener(Button3Task);
        btn4.onClick.AddListener(Button4Task);
    }

    //void OnCollisionEnter()
    //{
    //    CheckTask();
    //}


    void Button1Task()
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

    void Button2Task()
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
    void Button3Task()
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
    void Button4Task()
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

    //void CheckTask()
    //{
    //    if(!isActive1 )
    //    {
    //        GameObject.Find("Layer2").GetComponent<Button>().enabled = false;
    //    }

       
    //}



}

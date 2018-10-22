using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorQuestion : MonoBehaviour {

    //for randomize the question
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    
    [HideInInspector]
    public static int questionIndex;

    void Start()
    {
        Question();
    }

    public void Question()
    {
        switch (Random.Range(0,3))
        {
            case 0:
                //magenta (R,B)
                questionIndex = 0;
                hint1.SetActive(true);
                hint2.SetActive(false);
                hint3.SetActive(false);
                print("Q "+ questionIndex);
                break;

            case 1:
                //cyan (B,G)
                questionIndex = 1;
                hint2.SetActive(true);
                hint1.SetActive(false);
                hint3.SetActive(false);
                print("Q"+ questionIndex);
                break;

            default:
                //yellow (R,G)
                questionIndex = 2;
                hint3.SetActive(true);
                hint1.SetActive(false);
                hint2.SetActive(false);
                print("Q"+ questionIndex);
                break;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorResult : MonoBehaviour {

    public ParticleSystem blue;
    public ParticleSystem red;
    public ParticleSystem green;

    int currentQuestion;
    int winScore = 0;
    Color[] bowl;
    Color result;

    void Start()
    {
        result = new Color(0, 0, 0);
        currentQuestion = ColorQuestion.questionIndex;
        bowl = new Color[3];

        bowl[0] = new Color(1, 0, 0); //r
        bowl[1] = new Color(0, 1, 0); //g
        bowl[2] = new Color(0, 0, 1); //b
    }

    IEnumerator ChangeScene(int sceneIndex)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneIndex);
    }

    public void ResultColor(int index)
    {
        result += bowl[index];
    }

    void Update()
    {
        if (currentQuestion == 0)
        //magenta
        {
            switch (gameObject.name)
            {
                case "Red":
                    ResultColor(0);
                    //run some magic smoke etc...
                    break;
                case "Green":
                    ResultColor(1);
                    //run some magic smoke etc...
                    break;
                case "Blue":
                    print("Ddaeng!");
                    break;
                default:
                    print("Ddaeng!");
                    break;
            }

            if (result == new Color(1, 0, 1))
            {
                //put winning condition here
                //animation do something
                StartCoroutine(ChangeScene(1));
            }
        }

        if (currentQuestion == 1)
        //cyan
        {
            switch (gameObject.name)
            {
                case "Red":
                    //ResultColor(0);
                    print("Ddaeng!");
                    break;
                case "Green":
                    ResultColor(1);
                    //run some magic smoke etc...
                    break;
                case "Blue":
                    ResultColor(2);
                    //run some magic smoke etc...
                    break;
                default:
                    print("Ddaeng!");
                    break;
            }

            if (result == new Color(0, 1, 1))
            {
                //put winning condition here
                //animation do something
                StartCoroutine(ChangeScene(1));
            }
        }

        if (currentQuestion == 2)
        //yellow
        {
            switch (gameObject.name)
            {
                case "Red":
                    ResultColor(0);
                    //run some magic smoke etc...
                    //print("Ddaeng!");
                    break;
                case "Green":
                    ResultColor(1);
                    //run some magic smoke etc...
                    break;
                case "Blue":
                    print("Ddaeng!");
                    break;
                default:
                    //ResultColor(2);
                    print("Ddaeng!");
                    break;
            }

            if (result == new Color(1, 1, 0))
            {
                //put winning condition here
                //animation do somethings
                StartCoroutine(ChangeScene(1));
            }
        }

        GetComponent<Renderer>().material.color = result;
    }
}

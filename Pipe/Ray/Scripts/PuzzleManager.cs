using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PuzzleManager : MonoBehaviour {
    Valve4Rotate any;
    Valve4Rotate valve;
    float delay = 3f;

    void Start ()
    {
        GameObject valve4 = GameObject.Find("polySurface20");
        valve = valve4.GetComponent<Valve4Rotate>();
    }


    private void Update()
    {
        if(valve.position == "left")
        {
            print("You win!");
           // StartCoroutine(TransitionCountdown(delay));
        }
    }


    IEnumerator TransitionCountdown(float delay)
    {
        yield return new WaitForSeconds(delay);
        //SceneManager.LoadScene("")
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamelanMain : MonoBehaviour {

    //public Animator gamelanAnim;
    //public AudioSource gamelan;

    //store music in array
    public AudioSource[] you;

    private void Start()
    {
        you = new AudioSource[20];
    }

    private void Update()
    {
        for (int i = 0; i <= you.Length; i++)
        {
            you[i].Play();
        }
    }

    //public void OnMouseDown()
    //{
    //    if (gameObject.name == "gamelan0")
    //    {
    //        gamelan.Play();
    //        StartCoroutine(OnClickAnim());
    //        print("Gamelan1");
    //    }

    //    if (gameObject.name == "gamelan1")
    //    {
    //        gamelan.Play();
    //        StartCoroutine(OnClickAnim());
    //        print("Gamelan2");
    //    }

    //    if (gameObject.name == "gamelan2")
    //    {
    //        gamelan.Play();
    //        StartCoroutine(OnClickAnim());
    //        print("Gamelan3");
    //    }

    //    if (gameObject.name == "gamelan3")
    //    {
    //        gamelan.Play();
    //        StartCoroutine(OnClickAnim());
    //        print("Gamelan4");
    //    }

    //    if (gameObject.name == "gamelan4")
    //    {
    //        gamelan.Play();
    //        StartCoroutine(OnClickAnim());
    //        print("Gamelan5");
    //    }

    //    if (gameObject.name == "gamelan5")
    //    {
    //        gamelan.Play();
    //        StartCoroutine(OnClickAnim());
    //        print("Gamelan6");
    //    }

    //    if (gameObject.name == "gamelan6")
    //    {
    //        gamelan.Play();
    //        StartCoroutine(OnClickAnim());
    //        print("Gamelan7");
    //    }

    //    if (gameObject.name == "gamelan7")
    //    {
    //        gamelan.Play();
    //        StartCoroutine(OnClickAnim());
    //        print("Gamelan8");
    //    }
    //}

    //IEnumerator OnClickAnim()
    //{
    //    gamelanAnim.SetBool("Click", true);
    //    yield return new WaitForSeconds(.1f);
    //    gamelanAnim.SetBool("Click", false);
    //}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GamelanMain : MonoBehaviour {

    public UnityEvent OnClick = new UnityEvent();
    public GameObject thisGamelan;
    public Animator gamelanAnim;
    public AudioSource gamelan;

    private void Start()
    {

        thisGamelan = this.gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "stickL" || collision.gameObject.name == "stickR")
        {
            //StartCoroutine(OnClickAnim());
            //OnClick.Invoke();
            //print("Hit");
            if (gameObject.name == "gamelan0")
            {
                OnClick.Invoke();
                gamelan.Play();
                print("Gamelan1");
            }

            if (gameObject.name == "gamelan1")
            {
                OnClick.Invoke();
                gamelan.Play();
                print("Gamelan2");
            }

            if (gameObject.name == "gamelan2")
            {
                OnClick.Invoke();
                gamelan.Play();
                print("Gamelan3");
            }

            if (gameObject.name == "gamelan3")
            {
                OnClick.Invoke();
                gamelan.Play();
                print("Gamelan4");
            }

            if (gameObject.name == "gamelan4")
            {
                OnClick.Invoke();
                gamelan.Play();
                print("Gamelan5");
            }

            if (gameObject.name == "gamelan5")
            {
                OnClick.Invoke();
                gamelan.Play();
                print("Gamelan6");
            }

            if (gameObject.name == "gamelan6")
            {
                OnClick.Invoke();
                gamelan.Play();
                print("Gamelan7");
            }

            if (gameObject.name == "gamelan7")
            {
                OnClick.Invoke();
                gamelan.Play();
                print("Gamelan8");
            }
        }
    }

    IEnumerator OnClickAnim()
    {
        gamelanAnim.SetBool("Click", true);
        yield return new WaitForSeconds(.1f);
        gamelanAnim.SetBool("Click", false);
    }
}

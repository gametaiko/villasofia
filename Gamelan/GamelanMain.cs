using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GamelanMain : MonoBehaviour {

    public UnityEvent OnClick = new UnityEvent();

    GameObject[] nGamelan = new GameObject[10];
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
                nGamelan[0] = this.gameObject;
            }

            if (gameObject.name == "gamelan1")
            {
                OnClick.Invoke();
                gamelan.Play();
                nGamelan[1] = this.gameObject;
            }

            if (gameObject.name == "gamelan2")
            {
                OnClick.Invoke();
                gamelan.Play();
                nGamelan[2] = this.gameObject;
            }

            if (gameObject.name == "gamelan3")
            {
                OnClick.Invoke();
                gamelan.Play();
                nGamelan[3] = this.gameObject;
            }

            if (gameObject.name == "gamelan4")
            {
                OnClick.Invoke();
                gamelan.Play();
                nGamelan[4] = this.gameObject;
            }

            if (gameObject.name == "gamelan5")
            {
                OnClick.Invoke();
                gamelan.Play();
                nGamelan[5] = this.gameObject;
            }

            if (gameObject.name == "gamelan6")
            {
                OnClick.Invoke();
                gamelan.Play();
                nGamelan[6] = this.gameObject;
            }

            if (gameObject.name == "gamelan7")
            {
                OnClick.Invoke();
                gamelan.Play();
                nGamelan[7] = this.gameObject;
            }
        }
    }

    IEnumerator OnClickAnim()
    {
        gamelanAnim.SetBool("Click", true);
        yield return new WaitForSeconds(.1f);
        gamelanAnim.SetBool("Click", false);
    }

    //private void Update()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        print(nGamelan[i].name);
    //    }
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GamelanMain : MonoBehaviour {

    public UnityEvent OnClick = new UnityEvent();
    public GameObject thisGamelan;
    public Animator gamelanAnim;

    void Start()
    {
        thisGamelan = this.gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Left" || collision.gameObject.name == "Right")
        {
            StartCoroutine(OnClickAnim());
            OnClick.Invoke();
            print("Hit");
        }
    }

    IEnumerator OnClickAnim()
    {
        gamelanAnim.SetBool("Click", true);
        yield return new WaitForSeconds(.1f);
        gamelanAnim.SetBool("Click", false);
    }
}

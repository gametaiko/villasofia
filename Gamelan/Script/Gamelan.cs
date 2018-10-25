using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gamelan : MonoBehaviour {

    public UnityEvent OnClick = new UnityEvent();
    public GameObject definedButton;
    public AudioSource gamelanSound;

    // Use this for initialization
    void Start()
    {
        definedButton = this.gameObject;
    }

    private void OnMouseDown()
    {
        gamelanSound.Play();
        Debug.Log("Button Clicked");
        OnClick.Invoke();
    }
}

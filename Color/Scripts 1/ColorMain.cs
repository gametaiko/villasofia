using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorMain : MonoBehaviour {

    public UnityEvent OnClick = new UnityEvent();
    public GameObject thisColor;

    //public void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Color")
    //    {
    //        print("Clicked");
    //        OnClick.Invoke();
    //    }
    //}

    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit mHit;

        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out mHit) && mHit.collider.gameObject == gameObject && gameObject.tag == "Color")
        {
            print("Clicked");
            OnClick.Invoke();
        }
    }
}

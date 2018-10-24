using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve2Rotate : MonoBehaviour
{
    public string position;
    public int count;
    public bool rotatable = false;
    public Animator anim;
    public GameObject test;

  
    Valve1Rotate valve;

    private void Start()
    {
        GameObject valve1 = GameObject.Find("polySurface11");
        valve = valve1.GetComponent<Valve1Rotate>();
        anim = test.GetComponent<Animator>();
    }

 


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand")
        {
            CheckPrevious();
            print(rotatable);
            if (rotatable)
            {
                if (gameObject.tag == "Valve2")
                {
                    StartCoroutine(RotateAround(Vector3.forward, 90.0f, 1.0f));

                    RotateCount();
                    CheckPosition();
                    AudioSource squeak = GetComponent<AudioSource>();
                    squeak.Play();
                }
            }
            else
            {
                print("YOU LOSE!");
                //Sound effect
            }
        }
    }

    IEnumerator RotateAround(Vector3 axis, float angle, float duration)
    {
        float elapsed = 0.0f;
        float rotated = 0.0f;
        while (elapsed < duration)
        {
            float step = angle / duration * Time.deltaTime;
            transform.RotateAround(transform.position, axis, step);
            elapsed += Time.deltaTime;
            rotated += step;
            yield return null;
        }
        transform.RotateAround(transform.position, axis, angle - rotated);
    }

    public void RotateCount()
    {
        count++;
        if (count == 4)
        {
            count = 0;
        }
    }

    public void CheckPosition()
    {
        if (count == 0)
        {
            position = "up";
            print("Valve 2 is in up position!");
            
        }
        if (count == 1)
        {
            position = "right";
            print("Valve 2 is in right position!");
        }
        if (count == 2)
        {
            position = "down";
            print("Valve 2 is in down position!");
        }
        if (count == 3)
        {
            position = "left";
            print("Valve 2 is in left position!");
            anim.SetBool("stop", true);
        }
    }

    void CheckPrevious()
    {
       if(valve.position == "down")
        {
            rotatable = true;
            Debug.Log("Valve2 is rotatable!");
        }
       else
        {
            rotatable = false;
            Debug.Log("Valve 2 is not rotatable!");
        }
    }
}

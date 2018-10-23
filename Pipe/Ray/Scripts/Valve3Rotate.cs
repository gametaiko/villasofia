using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve3Rotate : MonoBehaviour
{
    public string position;
    public int count;
    //public bool nextIsRotatable = false;
    public bool rotatable = false;
    public Valve2Rotate any;

    Valve2Rotate valve;

    private void Start()
    {
        GameObject valve2 = GameObject.Find("polySurface16");
        valve = valve2.GetComponent<Valve2Rotate>();
    }

    private void OnMouseDown()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hand")
        {
            CheckPrevious();
            if (rotatable)
            {
                if (gameObject.tag == "Valve3")
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
                //Steam effect and reset stage
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
            print("Valve 3 is in up position!");
        }
        if (count == 1)
        {
            position = "right";
            print("Valve 3 is in right position!");
        }
        if (count == 2)
        {
            position = "down";
            print("Valve 3 is in down position!");
        }
        if (count == 3)
        {
            position = "left";
            print("Valve 3 is in left position!");
        }
    }

    void CheckPrevious()
    {
        if (valve.position == "left")
        {
            rotatable = true;
            Debug.Log("Valve 3 is rotatable!");
        }
        else
        {
            rotatable = false;
            Debug.Log("Valve 3 is not rotatable!");
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Valve1Rotate : MonoBehaviour {

    public string position;
    public int count;
    //private AudioSource audiosource;
    public Animator anim;
    public GameObject test;

    public AudioSource aud1;

    private void Start()
    {
        anim = test.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hand")
        {
            if (gameObject.tag == "Valve1")
            {
                StartCoroutine(RotateAround(Vector3.forward, 90.0f, 1.0f));
                RotateCount();
                CheckPosition();
                AudioSource squeak = GetComponent<AudioSource>();
                squeak.Play();
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
            print("Valve 1 is in up position!");
        }
        if (count == 1)
        {
            position = "right";
            print("Valve 1 is in right position!");
        }
        if (count == 2)
        {
            position = "down";
            print("Valve 1 is in down position!");
            anim.SetBool("stop", true);

            IEnumerator fadeSound1 = SoundFade.FadeOut(aud1, 0.5f);
            StartCoroutine(fadeSound1);
            gameObject.GetComponent<MeshCollider>().enabled = false;
        }
        if (count == 3)
        {
            position = "left";
            print("Valve 1 is in left position!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LampuSentuh : MonoBehaviour {

    public Transform hand;
    private void Update()
    {
        if(Vector3.Distance(hand.position, transform.position) < 1f)
        {
            Debug.Log("Move ke taman");
        }
    }
}

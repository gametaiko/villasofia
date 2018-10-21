using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LampuSentuh : MonoBehaviour {
    public string scene;
    public Transform hand;
    private void Update()
    {
        if(Vector3.Distance(hand.position, transform.position) < 0.5f)
        {
            SceneManager.LoadScene(scene);
            Debug.Log("Move ke taman");
        }
    }
}

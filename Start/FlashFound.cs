using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashFound : MonoBehaviour {

    public string scene;
    public float delay = 2;
    private bool one;
    // Update is called once per frame

    private void Start()
    {
        StartCoroutine(ScanHantu());
    }

    IEnumerator ScanHantu()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100f))
            {
                Debug.Log(hit.collider.gameObject);
                if (hit.collider.gameObject.tag == "hantu" & !one)
                {
                    one = true;
                    Debug.Log("Kena Hantu");
                    hit.collider.gameObject.GetComponent<Animator>().SetBool("found", true);
                    StartCoroutine(changeScene());
                }

            }

            yield return new WaitForSeconds(1f);
        }
    }

    void Update () {




    }


    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(delay);
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }
}

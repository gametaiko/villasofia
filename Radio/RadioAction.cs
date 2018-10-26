using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioAction : MonoBehaviour {

    public Animator ghost;
    public float timeScream;
	// Use this for initialization
	void Start () {
        StartCoroutine(checkIfAudioStop());
	}
	
    IEnumerator checkIfAudioStop()
    {
        yield return new WaitForSeconds(1f);

        while(true)
        {
            if(GetComponent<AudioSource>().time > timeScream)
            {
                break;
            }
            yield return new WaitForSeconds(1f);
        }


        ghost.SetBool("scream", true);

        yield return new WaitForSeconds(7f);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Room2");

    }

	// Update is called once per frame
	void Update () {
		
	}
}

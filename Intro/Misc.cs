using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Misc : MonoBehaviour {
    public bool isVersion;
    public bool isLoadDelay;
    public float delay = 5;
    public string scene;
	// Use this for initialization
	void Start () {

        if(isVersion)
        {
            GetComponent<Text>().text = "V" + Application.version;
        }

        if(isLoadDelay)
        StartCoroutine(LoadDelay());
	}
	
    IEnumerator LoadDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(scene);
    }
	// Update is called once per frame
	void Update () {
		
	}
}

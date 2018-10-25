using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCheck : MonoBehaviour {


    GameObject dustCloud;

    // Use this for initialization
    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "HandTouch")
        {
            Instantiate(dustCloud,transform.position, dustCloud.transform.rotation);
        }
		
	}

}

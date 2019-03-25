using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {

    public float countdown = 2f;

	// Update is called once per frame
	void Update () {
        
        countdown -= Time.deltaTime;    // countdown from 2-0

        if(countdown<1f)
        {
            disableTriggerOnPlayer();
        }

        if (countdown <= 0f)        //bomb is destroyed after 2 seconds
        {
            //FindObjectOfType<mapDestroyer>() to access public function from another script
            FindObjectOfType<mapDestroyer>().Explode(transform.position);
            Destroy(gameObject);        //Destroy the bomb object created
        }
		
	}

    void disableTriggerOnPlayer()
    {
        BoxCollider2D objectCollider;
        objectCollider = GetComponent<BoxCollider2D>();
        objectCollider.isTrigger = false;
    }
}

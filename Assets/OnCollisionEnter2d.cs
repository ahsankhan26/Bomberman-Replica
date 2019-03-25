using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnter2d : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
            Destroy(coll.gameObject);
    }
}

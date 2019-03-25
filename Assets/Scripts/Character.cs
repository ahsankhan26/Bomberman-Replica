using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// a character script is defined so that if multiple players/enemy etc is created. it should be assigned to this script
// this is an abstract class (abstract class is completed in other class)

public abstract class Character : MonoBehaviour {

    [SerializeField]
    private float speed = 3;    //value of speed is assigned in the inspector tab of unity editor

    private Animator animator;  //animator that controls sprites

    protected Vector2 direction;

	// Use this for initialization
	void Start () {

        
        animator = GetComponent<Animator>();    //gets the animation state
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        move(); //as long as the "GetKey()" function is running the move function will execute
	}
    void move()
    {
        transform.Translate(direction * speed * Time.deltaTime);    //deltaTime function changes value with time
        
        if(direction.x !=0 || direction.y !=0)
        {
            Animate(direction);
        }

        else { animator.SetLayerWeight(1, 0); }
    }

    public void Animate(Vector2 direction)
    {
        animator.SetLayerWeight(1, 1);   //Sets the weight of the layer at the given index.

        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }
}

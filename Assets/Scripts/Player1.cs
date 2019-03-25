using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Character {
	
	// Update is called once per frame
	protected override void Update () 
	{
		getInput (); //takes input from KeyBoard

        base.Update();
	}

	private void getInput()
	{
		direction = Vector2.zero; //initially there is no direction to player or a zero state i.e. Idle state

		if (Input.GetKey (KeyCode.UpArrow))     //if up arrow key is pressed the direction adds up allowing player to move up
		{
			direction += Vector2.up;
		}

		if (Input.GetKey (KeyCode.DownArrow)) //move down
		{
			direction += Vector2.down;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) //move left
		{
			direction += Vector2.left;
		}

		if (Input.GetKey (KeyCode.RightArrow)) //move right
		{
			direction += Vector2.right;
		}
	}
}

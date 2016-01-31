﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	protected int speed = 5;

	protected void Update ()
	{
		bool up = Input.GetKey (KeyCode.UpArrow);
		bool down = Input.GetKey (KeyCode.DownArrow);
		bool left = Input.GetKey (KeyCode.LeftArrow);
		bool right = Input.GetKey (KeyCode.RightArrow);

		if (up) {
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		}
		if (down) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
		}
		if (left) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}
		if (right) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}
	}
		
}

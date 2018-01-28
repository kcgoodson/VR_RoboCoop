using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour {

	int speed = 3;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Plus)) {
			speed += 1;
		} else if (Input.GetKeyDown (KeyCode.Minus)) {
			speed -= 1;
		}

		Vector3 move = new Vector3 ();
		if (Input.GetKey (KeyCode.W)) {
			move += Vector3.forward;
		} else if (Input.GetKey (KeyCode.S)) {
			move += Vector3.back;
		} else if (Input.GetKey (KeyCode.A)) {
			move += Vector3.left;
		} else if (Input.GetKey (KeyCode.D)) {
			move += Vector3.right;
		} else if (Input.GetKey (KeyCode.Q)) {
			move += Vector3.up;
		} else if (Input.GetKey (KeyCode.E)) {
			move += Vector3.down;
		}
		if (move != Vector3.zero) {
			transform.position += move.normalized * speed * Time.deltaTime;
		}
	}
}

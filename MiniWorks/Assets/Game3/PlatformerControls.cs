using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerControls : MonoBehaviour {

	public int speed = 3;
	Rigidbody r;

	void Start() {
		r = GetComponent<Rigidbody> ();
	}

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
		} if (Input.GetKey (KeyCode.S)) {
			move += Vector3.back;
		} if (Input.GetKey (KeyCode.A)) {
			move += Vector3.left;
		} if (Input.GetKey (KeyCode.D)) {
			move += Vector3.right;
		} if (Input.GetKey (KeyCode.Q)) {
			move += Vector3.up;
		} if (Input.GetKey (KeyCode.E)) {
			move += Vector3.down;
		}
		if (move != Vector3.zero) {
			r.velocity += move.normalized * speed * Time.deltaTime;
		}
	}
}
	

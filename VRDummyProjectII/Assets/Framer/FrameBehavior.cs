using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameBehavior : MonoBehaviour {

	GameObject[] defaultParts;
	GameObject[] parts;

	// Use this for initialization
	void Start () {
		parts = new GameObject[transform.childCount];
		for (int i = 0; i < parts.Length; i++) {
			parts[i] = gameObject.transform.GetChild(i).gameObject;
		}
		defaultParts = parts;
	}

	void OnCollisionEnter(Collision collision) {
		GameObject other = collision.gameObject;
		GameObject myFramePiece = (collision.contacts [0].thisCollider.gameObject);
		if (other.tag == "RobotPart" && !hasPart(other)) {
			int n = partIndex (myFramePiece); 
			other.transform.position = myFramePiece.transform.position;
			other.transform.rotation = myFramePiece.transform.rotation;
			other.transform.SetParent (gameObject.transform);
			Destroy (other.GetComponent<Rigidbody> ());
			Destroy(myFramePiece);
			parts [n] = other;
		}
	}

	int partIndex(GameObject g) {
		for (int i = 0; i < parts.Length; i++) {
			if (g == parts [i]) {
				return i;
			}
		}
		return -1;
	}

	public bool hasPart(GameObject g) {
		return partIndex(g) != -1;
	}
}

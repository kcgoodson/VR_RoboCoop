using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowStick : MonoBehaviour {

	bool hasHead;
	bool hasButt;

	void OnCollisionEnter(Collision c) {
		if (!hasHead && c.gameObject.tag == "Head") {
			hasHead = true;
			GameObject head = c.gameObject;
			head.GetComponent<Rigidbody> ().isKinematic = true;
			head.transform.SetParent (this.gameObject.transform);
		} else if (!hasButt && c.gameObject.tag == "Butt") {
			hasButt = true;
			GameObject butt = c.gameObject;
			butt.GetComponent<Rigidbody> ().isKinematic = true;
			butt.transform.SetParent (this.gameObject.transform);
		}
	}
}

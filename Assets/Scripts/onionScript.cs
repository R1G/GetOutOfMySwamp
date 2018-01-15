using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onionScript : MonoBehaviour {

	void OnCollisionEnter(Collision coll) {
		if (coll.transform.parent.gameObject.tag == "Enemy") {
			Debug.Log ("enemy collision");
			Destroy (coll.transform.parent.gameObject);
		}
		Destroy (gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour {

	float dTime = 0.0f;
	public GameObject mob;

	void Update() {
		dTime += Time.deltaTime;

		if (dTime >= 6.0f) {
			SpawnMob ();
			dTime = 0.0f;
		}
	}

	void SpawnMob() {
		Instantiate (mob, gameObject.transform.position, Quaternion.identity);
	}
}

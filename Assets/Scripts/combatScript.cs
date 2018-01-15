using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatScript : MonoBehaviour {

	public GameObject onion;
	public Transform firePos;

	public float attackTimerLimit;
	public int health;
	float attackTimer;
	float damageTimer;

	void Update () {
		attackTimer += 0.01f;
		damageTimer += 0.01f;
		if (Input.GetMouseButtonDown (0) && attackTimer >= attackTimerLimit) {
			GameObject projectile = Instantiate (onion, firePos.position, Quaternion.identity) as GameObject;
			projectile.GetComponent<Rigidbody> ().AddForce (transform.forward*100);
			attackTimer = 0;
		}
	}

	void OnCollisionStay(Collision coll) {
		if (coll.transform.parent != null && coll.transform.parent.gameObject.tag == "Enemy" && damageTimer >= 0.5f) {
			health -= 10;
			damageTimer = 0;
			if (health <= 0) {
				Application.Quit ();
			}
		}
			
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

	GameObject player;
	Camera cam;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		transform.LookAt (player.transform);
		if (cam != null) {
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit)) {
				player.transform.LookAt (hit.point);
			}
		}
	}
}

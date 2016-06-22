using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
	

	int flag = 0;

	// Use this for initialization


	
	// Update is called once per frame

			
	void Update () {
		if (flag == 1) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Rotate (new Vector3 (0, 0, 1), +5);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Rotate (new Vector3 (0, 0, 1), -5);
			}
		}
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Sphere"){
			flag = 1;
	    }
	}
}
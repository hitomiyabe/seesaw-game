﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
	int flag = 0;

	public Rigidbody rb;
	public GameObject particle;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		Screen.lockCursor = true;

	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			GetComponent<AudioSource> ().Play ();
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 15, 0);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GetComponent<Rigidbody> ().AddForce (0, -1000, 0);
			flag = 1;
		}
	else if (Input.GetKeyUp (KeyCode.DownArrow)) {
			GetComponent <Rigidbody> ().AddForce (0, -10, 0);
			flag = 0;
			}

		}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Cube") {
			//GetComponent<ParticleSystem> ();
			Instantiate (particle, transform.position, Quaternion.identity);
		}
		if (flag == 1) {
			if (other.gameObject.tag == "Enemy") {
				Destroy (other.gameObject);
			}
		}else if(other.gameObject.tag =="Enemy"){
			SceneManager.LoadScene ("GameOver");
		}
	}
}
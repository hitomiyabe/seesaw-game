using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver4 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Player") {
			SceneManager.LoadScene ("GameOver4");
		}
	}
}
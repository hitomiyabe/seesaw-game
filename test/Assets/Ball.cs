using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
public Rigidbody rb;
	// Use this for initialization
	void Start () {
			rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
		if (Input.GetButtonUp ("Jump"))
			rb.velocity = new Vector3 (0, 15, 0);
	}
}

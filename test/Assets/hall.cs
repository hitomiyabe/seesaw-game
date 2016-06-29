using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	flags = 0;
	// Use this for initialization
	void Start () {
	
	}

		float stpeTime
		float fpsRatio;
		Vector3 posA = new Vecotor3(2,0,0);
		Vector3 distance;
		// Update is called once per frame
		void Update () {
			if (Input.GetKey (KeyCode.Space)) {
				GetComponent<AudioSource> ().Play ();
				GetComponent<Rigidbody> ().velocity = new Vector3 (0, 15, 0);
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				GetComponent<Rigidbody> ().AddForce (0, -100, 0);
				flag = 1;
			}
			stepTime = Time.deltaTime;
			fpsRatio = Time.deltaTime * 60.0f;
			distance = posA - go.transform.position;
			distance *= 0.25f;
			float min = 0.01f;
			float max = 0.4f;

			if (distance.magnitude < min) {
				go.transform.position = posA;
			}else{
				if(distance.magnitude max>){
					distance *= max/distance.magnitude;
				}
				go.transform.position += distance*fpsRatio;
			}
		}

	}
}

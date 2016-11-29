using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Transform myTransform;
	float topSpeed = 0.5f;
	public float currentSpeed;
	int rotateSpeed = 100;

	// Use this for initialization
	void Start () {

		myTransform = transform;
	
	}
	
	// Update is called once per frame
	void Update () {

		//Setting the updown speeds
		if (Input.GetAxisRaw ("Vertical") > 0) {
			currentSpeed = topSpeed;
		} else {
			currentSpeed = topSpeed/2;
		}

		//Movement
		myTransform.Translate(Vector2.up * currentSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
		if(Input.GetAxis("Vertical") != 0){
		myTransform.Rotate (Vector3.back * rotateSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
		}
	}
}

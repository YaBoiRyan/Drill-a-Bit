using UnityEngine;
using System.Collections;

public class WormBehaviour : MonoBehaviour {

	Transform playerTransform;
	Transform myTransform;
	float speed = 0.1f;
	float moveCooldown = 4;
	Vector3 direction;
	bool Moving = false;

	void Start () 
	{
		direction = direction.normalized;
		playerTransform = GameObject.Find ("Drillbert").transform;
		myTransform = transform;
	}
	

	void Update () 
	{
		if (moveCooldown <= Time.time) 
		{
			Moving = !Moving;
			moveCooldown = Time.time + 4f;
		}
			
		if (Moving == true) 
		{
			speed = 0.1f;
		} 
		else 
		{
			speed = 0;
			direction = playerTransform.transform.position - myTransform.position;

			Vector3 vectorToTarget = playerTransform.position - myTransform.position;
			float angle = Mathf.Atan2 (vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
			Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
			transform.rotation = Quaternion.Slerp (transform.rotation, q, Time.deltaTime * 5);
		}

		Vector3 position = transform.position;
		position += direction * speed * Time.deltaTime;
		transform.position = position;
	}
}

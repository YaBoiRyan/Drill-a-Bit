using UnityEngine;
using System.Collections;

public class MoleBehaviour : MonoBehaviour {

	public bool horizontalPatrol;
	Transform playerTransform;
	Transform myTransform;
	bool moveDirection;
	float speedVertical = 0;
	float speedHorizontal= 0;
	Vector3 moveDirectionVertical = Vector3.down;
	Vector3 moveDirectionHorizontal = Vector3.left;
	float moveCooldown = 4;
	bool playerDetected = false;

	// Use this for initialization
	void Start () 
	{
		playerTransform = GameObject.Find ("Drillbert").transform;
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance(myTransform.position,playerTransform.position) < 1)
			{
				playerDetected = true;
			}

		if (playerDetected == true) 
		{
			if (playerTransform.position.x <= myTransform.position.x) 
			{
				speedHorizontal = 0.2f;
			}
			if (playerTransform.position.x >= myTransform.position.x) 
			{
				speedHorizontal = -0.2f;
			}
			if (playerTransform.position.y <= myTransform.position.y) 
			{
				speedVertical = 0.2f;
			}
			if (playerTransform.position.y >= myTransform.position.y) 
			{
				speedVertical = -0.2f;
			}
		}



		if (playerDetected == false)
			{
			
			if (moveCooldown <= Time.time) 
			{
				moveDirection = !moveDirection;
				moveCooldown = Time.time + 4f;
			}

			if (moveDirection == true) 
			{
				if (horizontalPatrol == true)
				{
					speedHorizontal = 0.2f;
				}
				if (horizontalPatrol == false)
				{
					speedVertical = 0.2f;
				}
			} 
			else 
			{
				if (horizontalPatrol == true)
				{
					speedHorizontal = -0.2f;
				}
				if (horizontalPatrol == false)
				{
					speedVertical = -0.2f;
				}
			}

			}

		myTransform.Translate (moveDirectionVertical * Time.deltaTime * speedVertical);
		myTransform.Translate (moveDirectionHorizontal * Time.deltaTime * speedHorizontal);
}
}
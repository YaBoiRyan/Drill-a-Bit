using UnityEngine;
using System.Collections;

public class WormBehaviour : MonoBehaviour {

	Transform playerTransform;
	Transform myTransform;
	Vector3 moveDirectionVertical = Vector3.down;
	Vector3 moveDirectionHorizontal = Vector3.left;
	float speedVertical = 1;
	float speedHorizontal = 0;
	bool isLeft = false;

	void Start () 
	{
		playerTransform = GameObject.Find ("PlayerGraphic").transform;
		myTransform = transform;

	}
	

	void Update () 
	{
	
		if (playerTransform.position.x < myTransform.position.x) 
		{
			speedHorizontal = 2f;
		}

		if (playerTransform.position.x > myTransform.position.x) 
		{
			speedHorizontal = -2f;
		}

		if (playerTransform.position.y < myTransform.position.y) 
		{
			speedVertical = 2f;
		}

		if (playerTransform.position.y > myTransform.position.y) 
		{
			speedVertical = -2f;
		}



		myTransform.Translate (moveDirectionHorizontal * Time.deltaTime * speedHorizontal);
		myTransform.Translate (moveDirectionVertical * Time.deltaTime * speedVertical);
	}
}

﻿using UnityEngine;
using System.Collections;

public class TerrainBackgroundShit : MonoBehaviour {

	SpriteRenderer mySpriteRenderer;
	Collider2D myCollider;
	public Sprite poopDirt;

	// Use this for initialization
	void Start () {

		mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		myCollider = gameObject.GetComponent<Collider2D>();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.CompareTag("Drill"))
		{
			mySpriteRenderer.sprite = poopDirt;
			myCollider.enabled = false;

		}

	}
}

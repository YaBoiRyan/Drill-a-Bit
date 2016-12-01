using UnityEngine;
using System.Collections;

public class TerrainBackgroundShit : MonoBehaviour {

	SpriteRenderer mySpriteRenderer;
	public Sprite poopDirt;

	// Use this for initialization
	void Start () {

		mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.CompareTag("Drill"))
		{
			mySpriteRenderer.sprite = poopDirt;
		}

	}
}

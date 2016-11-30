using UnityEngine;
using System.Collections;

public class DrillDestroy : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.CompareTag("DestroyableTerrain"))
		{
			Destroy (other.gameObject);
		}

	}
}

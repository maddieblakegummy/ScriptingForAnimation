using UnityEngine;
using System.Collections;

public class OrbDestroy : MonoBehaviour {
	
	
	 void OnTriggerEnter (Collider other)
		{
			if (other.gameObject.tag == "Player")
			{
				Destroy (gameObject);
			}
	}
}


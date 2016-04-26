using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public GameObject vortex;

	void Awake ()
	{
		vortex = GameObject.FindGameObjectWithTag ("Vortex");
	}

	public void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == vortex)
		{
			Application.LoadLevel ("WinScene");
		}
	}
}

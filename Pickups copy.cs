using UnityEngine;
using System.Collections;

public class Pickups : MonoBehaviour {

	protected int OrbValue = 1;
	
	protected AudioSource Magicwand;
	void Awake ()
	{
		Magicwand = GetComponent <AudioSource> ();
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Orb") 
		{
			OrbAdd ();
			Magicwand.Play ();
		}
	}
	public void OrbAdd () {
		OrbManager.orbs += OrbValue;

	}
}

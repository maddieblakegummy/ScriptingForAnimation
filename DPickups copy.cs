using UnityEngine;
using System.Collections;

public class DPickups : Pickups {
	
	
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "DOrb") 
		{
			DOrbAdd ();
			Magicwand.Play ();
		}
	}
	public void DOrbAdd () {
		BonusManager.Borbs += OrbValue;
	}
}

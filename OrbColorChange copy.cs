using UnityEngine;
using System.Collections;
using System;

public class OrbColorChange : MonoBehaviour {

	public static Action UpdateColor;

	void ColorUpdating ()
	{
		if (UpdateColor != null)
			UpdateColor ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		ColorUpdating ();
		gameObject.SetActive (false);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OrbManager : MonoBehaviour {

	public static int orbs;

	public Text ColorCollected;

	void Start ()
	{
		while (orbs < 1) {
			print ("Orb Collected");
			orbs--;
		}
	}

	void Awake ()
	{
		ColorCollected = GetComponent <Text> ();
		orbs = 0;
	}
	void Update ()
	{
		ColorCollected.text = "Color Collected: " + orbs + "/6";
	}
}


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BonusManager : MonoBehaviour {
	
	public static int Borbs;
	
	 public Text text;
	
	void Awake ()
	{
		text = GetComponent <Text> ();
		Borbs = 0;
	}
	void Update ()
	{
		text.text = "BONUS White Collected: " + Borbs + "/2";
	}
}
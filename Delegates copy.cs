using UnityEngine;
using System.Collections;

public class Delegates : MonoBehaviour {

	delegate void ShowDelegates();
	ShowDelegates completedDelegates;

	void Start ()
	{
		completedDelegates += Proof;
		completedDelegates += WrittenWords;

		completedDelegates();
	}

	void Proof ()
	{
		print ("Here is a delegate");
	}
	void WrittenWords()
	{
		Debug.Log ("Here is a multidelegate");
	}
}

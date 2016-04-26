using UnityEngine;
using System.Collections;

public class BaseColorChange : MonoBehaviour {

	SpriteRenderer sprites;
	public  Color startcolor = Color.black;
	public float changenumber = 0.14f;

	// Use this for initialization
	void Start () {

		OrbColorChange.UpdateColor += ChangingColor;
		sprites = GetComponent<SpriteRenderer> ();
		sprites.color = startcolor;
	}

		void ChangingColor ()
	{
		startcolor.r += changenumber;
		startcolor.b += changenumber;
		startcolor.g += changenumber;
		sprites.color = startcolor;
	}
}

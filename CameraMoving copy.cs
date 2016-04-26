using UnityEngine;
using System.Collections;

public class CameraMoving : MonoBehaviour {

	public GameObject Player;
	private Vector3 offset;

	void Start () 
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		offset = transform.position;
	}
	void LateUpdate () {
		transform.position = Player.transform.position + offset;
	}
}

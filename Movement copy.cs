using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 25.0f;
	bool grounded = true;
	public float jumpspeed = 250.0f;
    bool facingright = true;
	void Update () {
		var movespeed = (new Vector3 (Input.GetAxis ("Horizontal"), 0, 0)); 
		float move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody> ().position += movespeed * speed * Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump ();
		}

		if (move > 0 && !facingright) {
			Flip ();
		}
		else if (move < 0 && facingright) {
			Flip();
		}
	}
		void Jump ()
		{
		if (grounded == true) {
			GetComponent<Rigidbody> ().AddForce (new Vector2 (0, jumpspeed));
			grounded = false;
		}
	}
	void OnCollisionEnter (Collision hit){
		grounded = true;
	}
	void Flip (){
		facingright = !facingright;
		transform.Rotate (Vector2.up, 180);
	}
	}


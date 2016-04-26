using UnityEngine;
using System.Collections;

public class GemSpawn : MonoBehaviour {
	public playerhealth PlayerHealth;
	public GameObject gem;
	public float spawnTime = 15f;
	public Transform[] gempoints;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating ("GemSpawner", spawnTime, spawnTime);
	}
	
	void GemSpawner ()
	{
		if(PlayerHealth.currentHealth <= 0f)
		{
			return;
		}
		int spawnPointIndex = Random.Range (0, gempoints.Length);
		
		Instantiate (gem, gempoints[spawnPointIndex].position, gempoints[spawnPointIndex].rotation);
	}
}

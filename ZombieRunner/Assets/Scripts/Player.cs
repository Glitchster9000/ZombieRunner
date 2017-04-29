using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// normalize sound files through audacity

	// don't use mp3 files, use m4a (acc) for music and wav for sfx

	// try not to use these in update
	// SendMessage() goes to ALL Components of the self's GameObject
	// SendMessageUpwards() goes UP to ALL Parent GameObjects
	// BroadcastMessage() goes DOWN to ALL Children GameObject




	public Transform playerSpawnPoints; // parent of all spawn points
	public GameObject landingAreaPrefab;

	private bool reSpawn = false;
	private Transform[] spawnPoints;
	private bool lastRespawnToggle = false;


	// Use this for initialization
	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
		//		print(spawnPoints.Length);
	}
	
	// Update is called once per frame
	void Update () {
		if (lastRespawnToggle != reSpawn) { // when last they are not both false, ie when you click the button
			Respawn();
			reSpawn = false;
		} else {
			lastRespawnToggle = reSpawn;
		}
	}



	private void Respawn() {
		int i = Random.Range(1, spawnPoints.Length);
		transform.position = spawnPoints[i].transform.position;

	}


	void OnFindClearArea() {
		//		Debug.Log("found clear area in player.cs");
		Invoke("DropFlare", 3f);
	}


	void DropFlare() {
		Instantiate(landingAreaPrefab, transform.position, transform.rotation);
	}
}

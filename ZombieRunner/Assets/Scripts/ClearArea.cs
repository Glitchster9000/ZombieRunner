using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {



	public float timeSinceLastTrigger = 0f; // TODO MAKE PRIVATE


	private bool foundClearArea = false;

	void Update () {
		timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea) {
			foundClearArea = true;
			SendMessageUpwards("OnFindClearArea");// goes to player.cs OnFindClearArea()
			// looks up every parent for the method //

		}
	}


	void OnTriggerStay(Collider collider) {
		if (collider.tag != "Player") {
		timeSinceLastTrigger = 0f;
		}
	}



}

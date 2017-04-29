using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	private bool called = false;


	private Rigidbody rigidBody;


	void Start () {
//		audioSource = GetComponent<AudioSource>();
		rigidBody = GetComponent<Rigidbody>();
	}
	



	void DispatchHelicopter() {
		Debug.Log("Helicopter Called");
		called = true;
		rigidBody.velocity = new Vector3(0,0,50f);
}







}

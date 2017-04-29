using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {




	public AudioClip initialHeliCall;
	public AudioClip initialCallReply;

	private AudioSource audioSource;


	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();

	}



	void OnMakeInitialHeliCall() {
		print(name + " OnMakeInitialHeliCall");
		audioSource.clip = initialHeliCall;
		audioSource.Play();

		Invoke("InitialReply", initialCallReply.length + 1f); // wait 1 second
	}

	void InitialReply() {
		audioSource.clip = initialCallReply;
		audioSource.Play();

		BroadcastMessage("DispatchHelicopter");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {


	public AudioClip whatHappened;
	public AudioClip goodLandingArea;

	private AudioSource audioSource;


	void Start () {
		audioSource = GetComponent<AudioSource>();
		audioSource.clip = whatHappened;
		audioSource.Play();
	}
	

	void OnFindClearArea() {
		print(name + " OnFindClearArea");
		audioSource.clip = goodLandingArea;
		audioSource.Play();

		Invoke("CallHeli", goodLandingArea.length + 1f); // wait 1 second
	}


	void CallHeli() {
		SendMessageUpwards("OnMakeInitialHeliCall");
	}



}

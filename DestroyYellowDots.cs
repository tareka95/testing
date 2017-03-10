using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyYellowDots : MonoBehaviour {
	[HideInInspector]
	public static bool YellowDestroy;
	public AudioSource audioController;
	public AudioClip playClip;
	public ScoreManaging scoreManagerScript;

	void Start ()
	{
		 audioController = GameObject.Find ("SoundEffect").GetComponent <AudioSource> ();
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Pacman")) {
			scoreManagerScript.AddScore ();
		//	GetComponent <AudioSource> ().PlayOneShot (playClip);
			audioController.Play(); 
			YellowDestroy = true;
			Destroy (this.gameObject);
		} 
		else 
		{
			scoreManagerScript.once = true;
			YellowDestroy = false;
		}

	}

}

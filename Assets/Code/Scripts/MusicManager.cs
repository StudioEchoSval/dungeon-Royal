﻿using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip [] levelMusicChangeArray;
	
	private AudioSource audioSource;
	
	void Awake() {
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load: " + name);
	}
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded (int level) {
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		Debug.Log ("Playing cllip: " +thisLevelMusic );
		
		if (thisLevelMusic) { // if there  is some music attached
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.volume = PlayerPrefsManager.GetMasterVolume();		
			audioSource.Play ();
		}
	}
	
	public void SetVolume(float volume){
		audioSource.volume = volume;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class OptionsController : MonoBehaviour {
	
	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;
 
	private MusicManager musicManager;
	
	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.SetVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
		//Debug.Log (PlayerPrefsManager.GetDifficulty());
	}
	
	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);
		levelManager.LoadLevel ("01a Start");	
	}
	
	public void SetDefaults (){
		volumeSlider.value = 0.8f;
		difficultySlider.value = 2;
	}
}

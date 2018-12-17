using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	public float autoLoadNextLevelAfter;

	void Start (){
		if (autoLoadNextLevelAfter <= 0){
			Debug.Log ("Level auto load disable, use a positive number in seconds.");
		}else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}
	
	void Awake (){
		//Debug.Log ("Level manager Awake");
	}
	
	public void LoadLevel(string name){
		//Debug.Log("Level load requested for "+name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		//Debug.Log("Quit request");
		Application.Quit();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}

}

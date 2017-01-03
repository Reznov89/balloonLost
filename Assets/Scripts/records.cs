using UnityEngine;
using System.Collections;

public class records : MonoBehaviour {

	//Array que contiene el record de cada nivel: seteado para 10 niveles
	private int[] eachLevelRecord = new int[9];

	//currentScore trae el puntaje obtenido en el currentLevel
	public int currentScore;

	//currentLevel es un string que trae el nivel que se jugo
	public int currentLevel;

	void Awake () {
		DontDestroyOnLoad(this.gameObject);
	}

	public void setLevel (){
		//Muestra el record en el nivel en que se este jugando
	}

	public void getLevel (string levelName) {
		switch (levelName) {
		case "level1":
			currentLevel = 0;
			break;
		case "level2":
			currentLevel = 1;
			break;
		}
	}

	public void checkRecord (int levelNumber){
		if (eachLevelRecord[levelNumber] < currentScore){
			print("RECORD!");
		}
	}
	
	void loadFunction () {
		
	}

	void saveFunction () {
	
	}
	

}

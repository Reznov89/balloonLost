using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class records : MonoBehaviour {
	
	//currentScore trae el puntaje obtenido en el currentLevel
	public int currentScore;

	//currentLevel es un string que trae el nivel que se jugo
	public int currentLevel;

	public static records record;
	private string fileName;

	void Start () {
		loadFunction();
	}

	void Awake () {
		fileName = Application.persistentDataPath +"/data.dat";
		if (record == null) {
			record = this;	
			DontDestroyOnLoad(this.gameObject);
		}else if (record != this) {
			Destroy (gameObject);
		}
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

	public void checkRecord (int currentScore){
		//if (eachLevelRecord[levelNumber] < currentScore){
		//	print("RECORD!");
		//}
	}
	
	public void loadFunction () {
		/*BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Open(fileName,FileMode.Open);

		dataToSave data = (dataToSave) bf.Deserialize(file);
		//record = data.record

		file.Close();*/
	}

	public void saveFunction (int level, int score) {
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(fileName);

		dataToSave data = new dataToSave();
		data.eachLevelRecord[level] = score;

		bf.Serialize(file,data);
		file.Close();
	}

}

[Serializable]
class dataToSave{
	//Array que contiene el record de cada nivel: seteado para 10 niveles
	public int[] eachLevelRecord = new int[9];
}

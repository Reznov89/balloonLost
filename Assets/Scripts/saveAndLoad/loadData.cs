using UnityEngine;
using System.Collections;

public class loadData
{
	public static void loadAllData () 
	{
		gameData.level1Record = PlayerPrefs.GetInt("level1Top");
		Debug.Log ("-----------LOADING----------");
		gameData.level2Record = PlayerPrefs.GetInt("level2Top");
		gameData.level3Record = PlayerPrefs.GetInt("level3Top");
		gameData.level4Record = PlayerPrefs.GetInt("level4Top");
		gameData.level5Record = PlayerPrefs.GetInt("level5Top");
		gameData.level6Record = PlayerPrefs.GetInt("level6Top");
		gameData.level7Record = PlayerPrefs.GetInt("level7Top");
		gameData.level8Record = PlayerPrefs.GetInt("level8Top");
		gameData.level9Record = PlayerPrefs.GetInt("level9Top");
		gameData.level10Record = PlayerPrefs.GetInt("level10Top");
	}
}

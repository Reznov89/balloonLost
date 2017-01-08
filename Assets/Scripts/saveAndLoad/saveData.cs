using UnityEngine;
using System.Collections;

public class saveData
{
	public static void saveAllData() 
	{
		PlayerPrefs.SetInt ("level1Top", gameData.level1Record );
		Debug.Log ("---------------SAVING----------------");
		PlayerPrefs.SetInt ("level2Top", gameData.level2Record );
		PlayerPrefs.SetInt ("level3Top", gameData.level3Record );
		PlayerPrefs.SetInt ("level4Top", gameData.level4Record );
		PlayerPrefs.SetInt ("level5Top", gameData.level5Record );
		PlayerPrefs.SetInt ("level6Top", gameData.level6Record );
		PlayerPrefs.SetInt ("level7Top", gameData.level7Record );
		PlayerPrefs.SetInt ("level8Top", gameData.level8Record );
		PlayerPrefs.SetInt ("level9Top", gameData.level9Record );
		PlayerPrefs.SetInt ("level10Top", gameData.level10Record );

	}

}

using UnityEngine;
using System.Collections;

public class saveData
{
	public static void saveAllData(int level) 
	{
		Debug.Log ("---------------SAVING----------------");

		switch (level)
		{
		case 0:
			PlayerPrefs.SetString ("playerName", gameData.playerID);
			break;
		case 1:
			PlayerPrefs.SetInt ("level1Top", gameData.level1Record );
			break;
		case 2:
			PlayerPrefs.SetInt ("level2Top", gameData.level2Record );
			break;
		case 3:
			PlayerPrefs.SetInt ("level3Top", gameData.level3Record );
			break;
		case 4:
			PlayerPrefs.SetInt ("level4Top", gameData.level4Record );
			break;
		case 5:
			PlayerPrefs.SetInt ("level5Top", gameData.level5Record );
			break;
		case 6:
			PlayerPrefs.SetInt ("level6Top", gameData.level6Record );
			break;
		case 7:
			PlayerPrefs.SetInt ("level7Top", gameData.level7Record );
			break;
		case 8:
			PlayerPrefs.SetInt ("level8Top", gameData.level8Record );
			break;
		case 9:
			PlayerPrefs.SetInt ("level9Top", gameData.level9Record );
			break;
		case 10:
			PlayerPrefs.SetInt ("level10Top", gameData.level10Record );
			break;
		}
	}

}

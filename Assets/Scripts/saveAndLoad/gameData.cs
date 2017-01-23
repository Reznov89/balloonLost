using UnityEngine;
using System.Collections;

public class gameData : MonoBehaviour {

	string levelName;

	int level;

	public static gameData gameDATA;

	public static string playerID{get;set;}
	public static int level1Record{get;set;}
	public static int level2Record{get;set;}
	public static int level3Record{get;set;}
	public static int level4Record{get;set;}
	public static int level5Record{get;set;}
	public static int level6Record{get;set;}
	public static int level7Record{get;set;}
	public static int level8Record{get;set;}
	public static int level9Record{get;set;}
	public static int level10Record{get;set;}

	void Awake () 
	{
		if (gameObject == null)
		{
			gameDATA = this;
			DontDestroyOnLoad(gameObject);
		}
		else if (gameDATA != this)
		{
			Destroy (gameObject);
		}
	}
	
	public void checkMedal(int medal, string levelName) 
	{
		switch (levelName)
		{
		case "level1":
			level1Record = medal;
			level = 1;
			break;
		case "level2":
			level2Record = medal;
			level = 2;
			break;
		case "level3":
			level3Record = medal;
			level = 3;
			break;
		}

		saveData.saveAllData(level);
	
	}

}

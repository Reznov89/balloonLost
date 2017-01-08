using UnityEngine;
using System.Collections;

public class gameData : MonoBehaviour {

	string levelName;

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

	/*
	public Sprite bronzeMedal;
	public Sprite silverMedal;
	public Sprite goldMedal;
	public Sprite platinunMedal;
	*/

	void Awake () {
		DontDestroyOnLoad(gameObject);
	}
	
	public void checkMedal(int medal) 
	{
		levelName = Application.loadedLevelName;
		
		switch (levelName)
		{
		case "level1":
			level1Record = medal;
			break;
		case "level2":
			level2Record = medal;
			break;
		case "level3":
			level3Record = medal;
			break;
		}
		//Debug.Log("para el " + levelName + " corresponde la " + medal);
		saveData.saveAllData();
	}
	
	public void medalSet() 
	{
		/*switch (medal) 
		{
		case 0: //NO MEDAL
			Debug.Log ("Bronze");
			break;
		case 1:
			Debug.Log ("Silver");
			break;
		case 2:
			Debug.Log ("Gold");
			break;
		case 3:
			Debug.Log ("Platinun");
			break;
		case 4:
			Debug.Log ("No medal");
			break;
		}*/
	}


}

using UnityEngine;
using System.Collections;

public class medalLoad : MonoBehaviour 
{
	public Sprite medalBronze;
	public Sprite medalSilver;
	public Sprite medalGold;
	public Sprite medalPlatinun;

	public SpriteRenderer level1Medal;
	public SpriteRenderer level2Medal;
	
	void Awake () 
	{
		loadData.loadAllData();
		checkLevel1();
		checkLevel2();
	}

	void checkLevel1()
	{
		switch (gameData.level1Record)
		{
		case 0:
			level1Medal.sprite = medalBronze;
			Debug.Log ("check - Bronce");
			break;
		case 1:
			level1Medal.sprite = medalSilver;
			Debug.Log ("check - Silver");
			break;
		case 2:
			level1Medal.sprite = medalGold;
			Debug.Log ("check - Gold");
			break;
		case 3 :
			level1Medal.sprite = medalPlatinun;
			Debug.Log ("check - Platinun");
			break;
		case 4:
			level1Medal.sprite = null;
			break;
		}
	}

	void checkLevel2()
	{
		switch (gameData.level2Record)
		{
		case 0:
			level2Medal.sprite = medalBronze;
			Debug.Log ("check - Bronce");
			break;
		case 1:
			level2Medal.sprite = medalSilver;
			Debug.Log ("check - Silver");
			break;
		case 2:
			level2Medal.sprite = medalGold;
			Debug.Log ("check - Gold");
			break;
		case 3:
			level2Medal.sprite = medalPlatinun;
			Debug.Log ("check - Platinun");
			break;
		case 4:
			level2Medal.sprite = null;
			break;
		}
	}

}

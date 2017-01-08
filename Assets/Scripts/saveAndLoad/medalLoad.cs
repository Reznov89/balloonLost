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
		Application.targetFrameRate = 30;
	}

	void Start () {
		loadData.loadAllData();
		checkLevel1();
		//level1Medal.sprite = medalPlatinun;
		/*
		switch (gameData.level1Record)
		{
			case
		}*/
	}

	void checkLevel1()
	{
		switch (gameData.level1Record)
		{
		case 1:
			level1Medal.sprite = medalBronze;
			break;
		case 2:
			level1Medal.sprite = medalSilver;
			break;
		case 3:
			level1Medal.sprite = medalGold;
			break;
		case 4 :
			level1Medal.sprite = medalPlatinun;
			break;
		default:
			level1Medal.sprite = null;
			break;
		}
	}

}

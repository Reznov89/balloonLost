using UnityEngine;
using System.Collections;

public class begin : MonoBehaviour {
	
	public void checkEntrance () 
	{
		loadData.loadAllData();

		if (gameData.playerID == "") 
		{
			Application.LoadLevel("intro");
		}
		else 
			{
				Application.LoadLevel("levelSelect");
			}
		
	}

}

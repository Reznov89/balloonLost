using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class enterName : MonoBehaviour 
{

	string playerName;
	public Text textBox;
	
	public void checkText () {
		playerName = textBox.text;
		gameData.playerID = playerName;
		saveData.saveAllData(0);
		Application.LoadLevel("levelSelect");
	}

}

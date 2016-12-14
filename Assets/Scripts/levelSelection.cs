using UnityEngine;
using System.Collections;

public class levelSelection : MonoBehaviour {

	public void levelOne (){
		Application.LoadLevel("firstLevel");
	}

	public void levlTwo () {
		Application.LoadLevel("secondLevel");
	}

	public void quit () {
		Application.Quit();
	}

}

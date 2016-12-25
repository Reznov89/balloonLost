using UnityEngine;
using System.Collections;

public class levelSelection : MonoBehaviour {

	public void levelOne (){
		Application.LoadLevel("level1");
	}

	public void levlTwo () {
		Application.LoadLevel("level2");
	}

	public void quit () {
		Application.Quit();
	}

}

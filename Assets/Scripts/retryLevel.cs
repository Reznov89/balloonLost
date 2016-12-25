using UnityEngine;
using System.Collections;

public class retryLevel : MonoBehaviour {
	
	void OnMouseDown () {
		//Sonido de globo pinchado
		//animacion explosion
		Application.LoadLevel(Application.loadedLevelName);
	}
}

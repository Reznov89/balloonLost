using UnityEngine;
using System.Collections;

public class retryLevel : MonoBehaviour {
	
	void OnMouseDown () {
		Application.LoadLevel(Application.loadedLevelName);
	}
}

using UnityEngine;
using System.Collections;

public class changeSide : MonoBehaviour {
	
	public character ninja;
	public TextMesh pusher;
	bool side;

	void OnMouseDown () {
		ninja.isMoving = true;
		checkSide ();
		checkColor();
	}

	public void checkColor () {
		if (ninja.rightSide) {
			pusher.color = Color.black;
		} else {
			pusher.color = Color.white;
		}
	}

	void checkSide () {
		side = !ninja.rightSide;
		ninja.rightSide = side;
	}
	
}

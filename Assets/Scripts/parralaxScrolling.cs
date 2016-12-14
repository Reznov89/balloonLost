using UnityEngine;
using System.Collections;

public class parralaxScrolling : MonoBehaviour {

	public GameObject BG1;
	public GameObject BG2;
	public GameObject BG3;
	float moveSpeed = 0.03f;
	float offset;
	Renderer fondo1;
	Renderer fondo2;
	Renderer fondo3;
	
	void Awake () {
		fondo1 = BG1.GetComponent<Renderer>();
		fondo2 = BG2.GetComponent<Renderer>();
		fondo3 = BG3.GetComponent<Renderer>();
	}

	void FixedUpdate () {
		offset += moveSpeed * Time.deltaTime;
		fondo1.material.mainTextureOffset = new Vector2(0, offset);
		fondo2.material.mainTextureOffset = new Vector2(0, offset - 0.01f);
		fondo3.material.mainTextureOffset = new Vector2(0, offset - 0.02f);
	}
}

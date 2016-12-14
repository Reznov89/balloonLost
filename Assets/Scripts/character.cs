using UnityEngine;
using System.Collections;

public class character : MonoBehaviour {

	public bool isMoving = true;
	public bool rightSide = false;
	public float characterVel = 50f;
	public changeSide cSS;
	public setings st;
	public GameObject explosion;
	public AudioClip coin;
	public AudioClip levelComplete;
	public AudioClip[] balloonPop;

	public AudioSource levelSong;

	void Awake () {
	//	poping = GetComponent<AudioSource>();
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "wall") {
			isMoving = false;
		}
	}
	
	void OnTriggerEnter2D (Collider2D choque) {
		switch (choque.tag) {
		case "collectable":
			Destroy(choque.gameObject);
			AudioSource.PlayClipAtPoint(coin, this.transform.position);
			st.updateScore(5);
			break;
		case "Finish":
			st.levelComplete();
			levelSong.GetComponent<AudioSource>();
			levelSong.mute = true;
			//levelSong.enabled = false;
			AudioSource.PlayClipAtPoint(levelComplete, this.transform.position);
			break;
		case "fan":
			isMoving = true;
			rightSide = !rightSide;
			cSS.checkColor();
			break;
		case "spear":
			explode();
			st.gameOver ();
			break;
		case "GameController":
			explode();
			st.gameOver ();
			break;
		}
	}

	void Update () {
		if (isMoving) {
			if (rightSide) {
				transform.position += Vector3.right * Time.deltaTime * characterVel;
			} else {
				transform.position += Vector3.left * Time.deltaTime * characterVel;
			}
		}
	}

	void explode(){
		AudioSource.PlayClipAtPoint(balloonPop[Random.Range(0,2)], Camera.main.transform.position, 1f);
		Instantiate(explosion,this.transform.position,Quaternion.identity);
		Destroy (this.gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class retryLevel : MonoBehaviour {

	public GameObject explosion;
	public AudioClip explode;

	void OnMouseDown () {
		Instantiate(explosion,this.transform.position,Quaternion.identity);
		AudioSource.PlayClipAtPoint(explode, Camera.main.transform.position,1f);
		this.GetComponent<SpriteRenderer>().sprite = null;
		Invoke ("action",1f);
	}

	void action () {
		Application.LoadLevel(Application.loadedLevelName);
	}
}

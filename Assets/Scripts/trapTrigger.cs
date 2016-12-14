using UnityEngine;
using System.Collections;

public class trapTrigger : MonoBehaviour {

	public GameObject spear;
	public GameObject exclamation;
	bool isActive = false;
	bool flashing = false;
	float selfDestruct = 2f;
	
	void OnTriggerEnter2D (Collider2D crash) {
		if (crash.tag == "Player") {
			isActive = true;
			spear.SetActive(true);
		}
	}
	

	void Update () {
		exclamation.transform.position += Vector3.up * Time.deltaTime * 1f;
		if (isActive) {
			selfDestruct -= Time.deltaTime;
			blinkSign ();
			InvokeRepeating ("shootSpear", 0.8f, 0.3f);
		}
		if (selfDestruct < 0){
			Destroy(spear.gameObject);
			Destroy(exclamation.gameObject);
			Destroy(this.gameObject);
		}
	}

	void blinkSign () {
		if (flashing) {
			exclamation.SetActive(flashing);
			flashing = false;
			Invoke("blinkSign",0.4f);
		} else {
			exclamation.SetActive(flashing);
			flashing = true;
			Invoke("blinkSign",0.4f);
		}
	}

	void shootSpear () {
		spear.transform.position += Vector3.up * Time.deltaTime * 10f;
	}
}

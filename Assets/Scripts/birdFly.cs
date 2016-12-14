using UnityEngine;
using System.Collections;

public class birdFly : MonoBehaviour {

	public bool rightFly = false;
	public float flyVel = 2f;

	void Update () {
		this.transform.position += Vector3.right * Time.deltaTime * flyVel;
	}
}

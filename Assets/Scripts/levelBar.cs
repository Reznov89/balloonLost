using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelBar : MonoBehaviour {

	//float percentage = 80f;
	float counter = 2f;
	bool began = false;

	public Slider progress;

	void Start () {
		//slider = GetComponent<>();
	}
	
	// Update is called once per frame
	void Update () {
		counter -= Time.deltaTime;
		if (counter < 0) 
		{
			began = true;
		}

		if (began) 
		{
			progress.value -= Time.deltaTime; 
		}
	}
}

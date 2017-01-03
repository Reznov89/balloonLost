using UnityEngine;
//using System.Collections;
using UnityEngine.UI;

public class setings : MonoBehaviour {

	float generalSpeed = 0f;
	float counter = 2f;
	public Transform character;
	public Transform cameraMain;
	public Transform UIelements;

	//EXTERNAL CLASSES
	public MedalSystem medalist;
	
	//Game Over elements
	public bool loss = false;
	public GameObject lossScreen;
	Animator GOScreen;

	//Level complete elements
	public bool won = false;
	public GameObject wonScreen;
	Animator LCScreen;

	//Score elements
	public TextMesh scoring;
	public TextMesh scoring2;
	int points;
    public Text scoreUI;

	//script records
	public records record;

	void Awake ()
    {
		GOScreen = lossScreen.GetComponent<Animator>();
		LCScreen = wonScreen.GetComponent<Animator>();
        medalist = GetComponent<MedalSystem>();
	}

	void Update ()
    {
		counter -= Time.deltaTime;
		if (counter < 0){
			generalSpeed = 5f;
		}

		if (loss == false || won == true)
        {
			character.position += Vector3.up * Time.deltaTime * generalSpeed;
			cameraMain.position += Vector3.up * Time.deltaTime * generalSpeed;
			UIelements.position += Vector3.up * Time.deltaTime * generalSpeed;
		}
	}

	public void gameOver ()
    {
		loss = true;
		GOScreen.SetBool("isOver",true);
        medalist.GetPoints(points);
		//enviar datos a records

    }

	public void levelComplete ()
    {
        updateScore(25);
        won = true;
        medalist.GetPoints(points);
        LCScreen.SetBool("isComplete",true);
		//enviar datos a records
	}

    public void updateScore(int point)
    {
        points += point;
        scoring.text = points.ToString();
        scoring2.text = points.ToString();
        scoreUI.text = points.ToString();
    }

}

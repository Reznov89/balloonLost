using UnityEngine;
//using System.Collections;

[System.Serializable]
public enum TypeMedals
{
	bronze,
	silver,
	gold,
	platinum,
	defaultMedal
}


public class MedalSystem : MonoBehaviour {

	private int bronzePoint = 40;
	private int silverPoint = 55;
	private int goldPoint = 60;
	private int platinunPoint = 105;
	public TypeMedals typeMedals;
	//public int points;

    //Medals
    public Sprite[] medalImage;
    SpriteRenderer medal1;
    SpriteRenderer medal2;
    public GameObject medalWon;
    public GameObject medalLoss;

	//Vincula al gameData para guardar medallas
	public gameData gD;

    void Awake()
	{
        medal1 = medalWon.GetComponent<SpriteRenderer>();
        medal2 = medalLoss.GetComponent<SpriteRenderer>();
    }

	public void GetPoints(int points)
	{
		if (points >= bronzePoint && points < silverPoint)
        {
            //BRONCE
            SetMedals(0);
			typeMedals = TypeMedals.bronze;
			gD.checkMedal(0);

		}
		else if (points >= silverPoint && points < goldPoint)
        {
            //SILVER
			SetMedals(1);
			typeMedals = TypeMedals.silver;
			gD.checkMedal(1);
		}
		else if (points >= goldPoint && points < platinunPoint)
        {
            //GOLD
            SetMedals(2);
			typeMedals = TypeMedals.gold;
			gD.checkMedal(2);
		}
		else if (points == platinunPoint)
        {
            //PLATINUN
            SetMedals(3);
			typeMedals = TypeMedals.platinum;
			gD.checkMedal(3);
		}
		else
        {
            //NO MEDAL
            medal1.sprite = null;
            medal2.sprite = null;
            typeMedals = TypeMedals.defaultMedal;
			gD.checkMedal(4);
		}		
	}

	public void SetMedals(int which)
	{
        medal1.sprite = medalImage[which];
        medal2.sprite = medalImage[which];
    } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class add_food : MonoBehaviour {

	public static Image i;

	public void Add_Food(){

		Opening_Values.foods_chosen++;

		string fc = "Image" + Opening_Values.foods_chosen;

		Debug.Log ("fc" + fc);
		i = GameObject.Find (fc).GetComponent<Image> ();



		//	Opening_Values.FoodObjsp[ = new GameObject[Opening_Values.foods_chosen];

		//	Opening_Values.FoodObjs[Opening_Values.foods_chosen].name = Opening_Values.selectedfood;
		Opening_Values.foodObjs[Opening_Values.foods_chosen]= Opening_Values.selectedfood;
		Opening_Values.foodDescriptions[Opening_Values.foods_chosen]= Opening_Values.selectedfoodfd;



		Opening_Values.foodGroup[Opening_Values.foods_chosen]= Opening_Values.selectedfoodfoodgroup;

		i.sprite = Resources.Load<Sprite> ("flags/" + Opening_Values.selectedfood);
		//	i.
		//	Debug.Log ("add food");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}


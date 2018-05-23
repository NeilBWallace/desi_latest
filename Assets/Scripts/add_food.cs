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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class choose_the_food : MonoBehaviour {

	public Transform spawnPos;
	public GameObject spawnee;
	public GameObject g;
	public Transform[] spawnLocations;
	public GameObject[] FoodSpawns;

	[SerializeField]
	public GameObject food_panel;

	[SerializeField]
	public GameObject choose_food_panel;

	[SerializeField]
	public GameObject rb;

	public Material[] material;
	Renderer rend;
	public static int chosen=0;
	public static int pos=20;

	public Button yourbutton;
	// Use this for initialization
	void Start () {
		Button btn = yourbutton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log ("select");
		spawnPos.Translate(0,0,pos);
	//	Vector3 v = new Vector3(100f,-100f,3f);
		pos++;
	//	spawnPos.position =v;


		g=(GameObject)Instantiate (spawnee, spawnPos.position, spawnPos.rotation);
		g.name = Opening_Values.selectedfood;
		g.GetComponent<stats>().strength=Opening_Values.selectedfoodstrength;
		g.GetComponent<stats>().health=Opening_Values.selectedfoodhealth;
		g.GetComponent<stats>().smartness=Opening_Values.selectedfoodsmartness;
		g.GetComponent<stats>().fd=Opening_Values.selectedfoodfd;
		g.GetComponent<stats> ().food_group = Opening_Values.selectedfoodfoodgroup;
	//	if (chosen == 0) {
	//		fo1 = GameObject.FindGameObjectWithTag ("FO1");
	///	ItemPickup i = spawnee.GetComponent<ItemPickup> ();
	//	i.item.strength = 5;
		Debug.Log ("xxx" + g.name);
	///	i.item.name = 	Opening_Values.selectedfood;
	//		i.item.strength = Opening_Values.selectedfoodstrength;
	//		i.item.health = Opening_Values.selectedfoodhealth;
	//		i.item.smartness = Opening_Values.selectedfoodsmartness;
	//		i.item.fd = Opening_Values.selectedfoodfd;
	//		rend = fo1.GetComponent<Renderer> ();
	//		rend.material.color = Color.green;
	//		chosen++;
	//	}else if(chosen == 1){
	//		fo2 = GameObject.FindGameObjectWithTag ("FO2");
	//		ItemPickup i = fo2.GetComponent<ItemPickup> ();
	//		i.item.name = 	Opening_Values.selectedfood;
	//		i.item.strength = Opening_Values.selectedfoodstrength;
	//		i.item.health = Opening_Values.selectedfoodhealth;
	//		i.item.smartness = Opening_Values.selectedfoodsmartness;
	//		i.item.fd = Opening_Values.selectedfoodfd;
	//		rend = fo2.GetComponent<Renderer> ();
	//		rend.material.color = Color.green;
	//		chosen++;

	//	}else if(chosen == 2){
	//		fo3 = GameObject.FindGameObjectWithTag ("FO3");
	//		ItemPickup i = fo3.GetComponent<ItemPickup> ();
	//		i.item.name = 	Opening_Values.selectedfood;
	//		i.item.strength = Opening_Values.selectedfoodstrength;
	//		i.item.health = Opening_Values.selectedfoodhealth;
	//		i.item.smartness = Opening_Values.selectedfoodsmartness;
	//		i.item.fd = Opening_Values.selectedfoodfd;
	//		rend = fo3.GetComponent<Renderer> ();
	//		rend.material.color = Color.green;
	//		chosen++;
//

		CanvasGroup c =GameObject.Find("rb").GetComponent<CanvasGroup> ();
		c.alpha = 1;

	

		c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
		c =GameObject.Find("Choose_Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
//		}


	}
	// Update is called once per frame
	void Update () {

	}
}

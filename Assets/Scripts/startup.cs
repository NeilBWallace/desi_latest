using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class startup : MonoBehaviour {

	public Transform spawnPos;
	public GameObject spawnee;
	public GameObject g;
	public Transform[] spawnLocations;
	public GameObject[] FoodSpawns;
	public static int pos=0;
	// Use this for initialization
	void Start () {
		
		if (Application.loadedLevelName == "parental_setup") {

	//		Vector3 v = new Vector3 (100f, -100f, 3);
	
	//		spawnPos.position = v;
			for (int i = 0; i <= Opening_Values.foods_chosen; i--{
				spawnPos.Translate (0, 0, pos);
				g = (GameObject)Instantiate (spawnee, spawnPos.position, spawnPos.rotation);
				g.name = Opening_Values.selectedfood;
				pos=pos +3;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

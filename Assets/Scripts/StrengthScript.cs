using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthScript : MonoBehaviour {
	public static int chosen_food = 0;

	public static string current_food;
	public static float strength_red=0.9f;
	public static float health_red=0.8f;
	public static float smartness_red=0.6f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (strength_red <0f){strength_red = 0f;}
		if (health_red <0f){health_red = 0f;}
		if (smartness_red <0f){smartness_red = 0f;}
	}
}

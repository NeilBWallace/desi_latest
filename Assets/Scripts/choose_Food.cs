using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choose_food : MonoBehaviour {

	[SerializeField]
	public GameObject rb;

	public Material[] material;
	Renderer rend;
	public static int chosen=0;

	public Button yourbutton;
	// Use this for initialization
	void Start () {
		Button btn = yourbutton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		

			
	}
	// Update is called once per frame
	void Update () {

	}
}

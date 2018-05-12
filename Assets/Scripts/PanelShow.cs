using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelShow : MonoBehaviour {


	public GameObject Panel;
	int counter;

	public void showhidePanel()
	{

		counter++;
		if (counter % 2 == 1) {
			Panel.gameObject.SetActive (false);
		} else {
			Panel.gameObject.SetActive (true);

		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

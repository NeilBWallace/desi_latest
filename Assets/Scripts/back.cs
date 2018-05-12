using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back : MonoBehaviour {
	[SerializeField]
	private GameObject food_panel;

	[SerializeField]
	private GameObject eat_food_panel;


	public Button yourbutton;
	// Use this for initialization
	void Start () {
		Button btn = yourbutton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{

		Time.timeScale = 1f;
	//	GameObject.Find ("Back").GetComponent<AudioSource> ().Play ();

		Debug.Log ("you clicked");
	//	Opening_Values.move = 1;

		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
		c =GameObject.Find("Eat_Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;

	
	}
	

}

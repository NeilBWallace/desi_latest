using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour {

	[SerializeField]
	public GameObject foodbank_panel;

	[SerializeField]
	public GameObject food_panel;

	[SerializeField]
	public GameObject rb;

	[SerializeField]
	public GameObject desi;

	public Button yourbutton;
	// Use this for initialization
	void Start () {
		Button btn = yourbutton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{

		Time.timeScale = 1f;
		Debug.Log ("you clickedd");
	//	Opening_Values.move = 1;

		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
		c =GameObject.Find("foodbank_panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
		c =GameObject.Find("rb").GetComponent<CanvasGroup> ();
		c.alpha = 0;

		desi.SetActive (true);

	}
	// Update is called once per frame
	void Update () {
		
	}
}

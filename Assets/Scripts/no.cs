using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class no : MonoBehaviour {



	[SerializeField]
	public GameObject rb;


	public Button yourbutton;
	// Use this for initialization
	void Start () {
		Button btn = yourbutton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		CanvasGroup c =GameObject.Find("rb").GetComponent<CanvasGroup> ();
		c.alpha = 0;

	}
	// Update is called once per frame
	void Update () {
		
	}
}

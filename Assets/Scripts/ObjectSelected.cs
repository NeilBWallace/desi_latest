using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectSelected : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetMouseButtonDown (0)) {

		//	Time.timeScale = 0f;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
		
				Debug.Log (hit.transform.name);

				if ((hit.transform.name != "Terrain") || hit.transform.name.Contains("Rock")){

					GameObject.Find ("Food_Sound").GetComponent<AudioSource> ().Play ();


					CanvasGroup c = GameObject.Find ("Food_Panel").GetComponent<CanvasGroup> ();
					c.alpha = 1;

					c = GameObject.Find ("Eat_Food_Panel").GetComponent<CanvasGroup> ();
					c.alpha = 1;

					Text t = GameObject.Find ("food_title1").GetComponent<Text> ();
					t.text = hit.transform.name;

					Image i = GameObject.Find ("foodbank").GetComponent<Image> ();

					i.sprite = Resources.Load<Sprite> ("flags/" + hit.transform.name);

						Text g = GameObject.Find ("fd").GetComponent<Text> ();
					g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().fd.ToString();

							g = GameObject.Find ("strength").GetComponent<Text> ();
					g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().strength.ToString();


						g = GameObject.Find ("health").GetComponent<Text> ();
					g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().health.ToString();

							g = GameObject.Find ("smartness").GetComponent<Text> ();
					g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().smartness.ToString();

						g = GameObject.Find ("food_group").GetComponent<Text> ();
					g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().food_group.ToString();

				}
			}
		}
	}
}

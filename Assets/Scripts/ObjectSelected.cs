using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectSelected : MonoBehaviour {

	private AudioSource[] allAudioSources;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetMouseButtonDown (0)) {
			

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {



				if (hit.transform.tag.Contains("Food")){

					AudioSource audio = gameObject.AddComponent<AudioSource>();
					allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
					//	GameObject.Find ("Food_Sound").GetComponent<AudioSource> ().Play ();
					foreach(AudioSource audioS in allAudioSources){
						audioS.Stop();
					}
					Debug.Log ("play audio" + hit.transform.name);
					audio.PlayOneShot((AudioClip)Resources.Load("audio/" +hit.transform.name));

				
				//	GameObject.Find ("Food_Sound").GetComponent<AudioSource> ().Play ();
					CanvasGroup d = GameObject.Find ("Food_Canvas").GetComponent<CanvasGroup> ();
					d.alpha = 1;

					CanvasGroup c = GameObject.Find ("Food_Panel").GetComponent<CanvasGroup> ();
					c.alpha = 1;

		
					Text t = GameObject.Find ("title").GetComponent<Text> ();
					t.text = hit.transform.name;

				//	GameObject.Find (t.text ).GetComponent<AudioSource> ().Play ();


					Image i = GameObject.Find ("Food_Image").GetComponent<Image> ();
					Debug.Log ("gg" + hit.transform.name);
					i.sprite = Resources.Load<Sprite> ("flags/" + hit.transform.name);

						Text g = GameObject.Find ("Description").GetComponent<Text> ();
					g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().fd.ToString();

		//					g = GameObject.Find ("strength").GetComponent<Text> ();
		//			g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().strength.ToString();


		//				g = GameObject.Find ("health").GetComponent<Text> ();
		//			g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().health.ToString();

		//					g = GameObject.Find ("smartness").GetComponent<Text> ();
		//			g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().smartness.ToString();

				g = GameObject.Find ("Food_Group").GetComponent<Text> ();
					g.text =GameObject.Find (hit.transform.name).GetComponent<stats>().food_group.ToString();
			//	t.text = t.text + "(" + GameObject.Find (hit.transform.name).GetComponent<stats> ().food_group.ToString () + ")";
			
				}
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back : MonoBehaviour {
	



	public void Back()
	{

		Time.timeScale = 1f;

		GameObject[] objs;
		objs = GameObject.FindGameObjectsWithTag ("Good_Food");
		foreach (GameObject o in objs) {
			GameObject.Find (o.name ).GetComponent<AudioSource> ().Stop ();
		}

		objs = GameObject.FindGameObjectsWithTag ("Bad_Food");
		foreach (GameObject o in objs) {
			GameObject.Find (o.name ).GetComponent<AudioSource> ().Stop ();	
		}


	GameObject.Find ("Back").GetComponent<AudioSource> ().Play ();

	

		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
	

	
	}
	

}

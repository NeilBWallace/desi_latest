using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat_Item : MonoBehaviour {

	void Start () {
//	Button btn = yourbutton.GetComponent<Button> ();
//btn.onClick.AddListener (TaskOnClick);
	}

	public void Eat_Food()
	{
		Time.timeScale = 1f;

		Debug.Log ("Eat Item");
	

		GameObject[] objs;
		objs = GameObject.FindGameObjectsWithTag ("enemy");
		foreach (GameObject o in objs) {
		//	AudioSource enemyAudio = o.GetComponent <AudioSource> ();
		//	enemyAudio.clip = deathClip;
		//	enemyAudio.Play ();
		//	o.GetComponent<EnemyHealth> ().StartSinking ();
			GameObject.Destroy (o);
			//	o.GetComponent<EnemyHealth> ().Death ();
		//	o.GetComponent<EnemyHealth> ().StartSinking ();
		}
			


		Text t = GameObject.Find ("food_title1").GetComponent<Text> ();
		Debug.Log ("ttt" + t.text);
		GameObject g = GameObject.Find (t.text);


		if (g.tag == "FO1") {
			GameObject.Find ("TastyVoice").GetComponent<AudioSource> ().Play ();
	ScoreManager.score =ScoreManager.score + 1;

  		
		}else
		{
			GameObject.Find ("burp").GetComponent<AudioSource> ().Play ();
	}

		Destroy(g);

		Debug.Log ("eat food");
	//	Opening_Values.move = 1;


		Debug.Log (ScoreManager.score);

		t = GameObject.Find ("ScoreText").GetComponent<Text> ();
		t.text = "Score: " + ScoreManager.score;

	  //  StrengthScript.strength_red -=float.Parse(strength.text)/10; 
	  //  strength_red.fillAmount = StrengthScript.strength_red; 

		//StrengthScript.health_red -=float.Parse(health.text)/10; 
	 //   health_red.fillAmount = StrengthScript.health_red; 

	  //  StrengthScript.smartness_red -= float.Parse(smartness.text)/10; 
	//	smartness_red.fillAmount = StrengthScript.smartness_red; 


		Debug.Log ("werwerw");
		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
		c =GameObject.Find("Eat_Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
	
		Time.timeScale = 1f;
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlaySnow : MonoBehaviour {
	public GameObject fx_Snow;
	public Text credits;

	// Use this for initialization
	void Start () {

		StartCoroutine(Example());

		StartCoroutine(Example2());
	}

	IEnumerator Example2()
	{   

		yield return new WaitForSeconds(65);
		//fx_Snow.SetActive (false);

		SceneManager.LoadScene (0);
	}

	IEnumerator Example()
	{   

		yield return new WaitForSeconds(60);
		fx_Snow.SetActive(true);


	}



	// Update is called once per frame
	void Update () {
		
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlaySnow2 : MonoBehaviour {
	public GameObject fx_Snow;
	public Text credits;

	// Use this for initialization
	void Start () {
		fx_Snow.SetActive(true);

	//	StartCoroutine(Example());

	//	StartCoroutine(Example2());
	}

	IEnumerator Example2()
	{   

	yield return new WaitForSeconds(5);
		fx_Snow.SetActive (false);

	//	SceneManager.LoadScene (3);
	}

//	IEnumerator Example()
//	{   

	//	yield return new WaitForSeconds(5);
		//fx_Snow.SetActive(false);


//	}



	// Update is called once per frame
	void Update () {
		
	
	}
}

//
//  ListControllerTest.cs
//
//  Author:
//       Tomaz Saraiva <tomaz.saraiva@gmail.com>
//
//  Copyright (c) 2017 Tomaz Saraiva
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using AddComponent;
using UnityEngine.UI;
using System.Linq;

public class ListController : MonoBehaviour
{
	

	[SerializeField]
	private  GameObject opening_text;

	[SerializeField]
	public GameObject choose_food_panel;


	[SerializeField]
	public GameObject rb;

	public Material[] material;
	Renderer rend;



	[SerializeField]
	private Image strength_red;

	[SerializeField]
	private Image health_red;

	[SerializeField]
	private Image smartness_red;


	[SerializeField]
	private Text health;
	[SerializeField]
	private Text strength;
	[SerializeField]
	private Text smartness;


	[SerializeField]
	private Image foodbank1;

	[SerializeField]
	private Text food_group;


	[SerializeField]
	private Text food_title1;

	[SerializeField]
	private Text food_description;

	[SerializeField]
	private Image food;

	[SerializeField]
	private  Text fd;


	[SerializeField]
	public List _list;

	[SerializeField]
	public ListItemBase _listItem;


	private AudioSource[] allAudioSources;

	static string description;

	private int _selectedIndex;

	public ListItemCountry _selectedItem;

	public List<KeyValuePair<string, Country>> _countries;


	void Start()
	{
		strength_red.fillAmount = StrengthScript.strength_red;
		health_red.fillAmount = StrengthScript.health_red;
		smartness_red.fillAmount = StrengthScript.smartness_red;
		_countries = Countries.Dictionary.ToList ();

		_list.onItemLoaded = HandleOnItemLoadedHandler;		// called when an item is recycled
		_list.onItemSelected = HandleOnItemSelectedHandler;	// called when the item is selected

		_list.Create (_countries.Count, _listItem); // create the list with a number and a prefab
		_list.gameObject.SetActive (true);
	}

	void Update()
	{
		
	}
	void HandleOnItemSelectedHandler (ListItemBase item) // reference to the selected list item
	{
		if(_selectedItem != null)
		{
			_selectedItem.Select (false);
		}

		_selectedItem = (ListItemCountry)item;
		_selectedItem.Select (true);

		_selectedIndex = _selectedItem.Index;
	
		StrengthScript.strength_red -= float.Parse(_countries[item.Index].Value.Strength)/10; 
			//	strength_red.fillAmount = StrengthScript.strength_red; 


				StrengthScript.health_red -= float.Parse(_countries[item.Index].Value.Health)/10; 
	//			health_red.fillAmount = StrengthScript.health_red; 
	 

			StrengthScript.smartness_red -= float.Parse(_countries[item.Index].Value.Smartness)/10; 
	//		smartness_red.fillAmount = StrengthScript.smartness_red; 
				StrengthScript.current_food = _countries [item.Index].Value.Name.ToLower (); 




		food_title1.GetComponent<Text> ().text = StrengthScript.current_food;
	//	Color temp = foodbank1.color;
	//	temp.a = 1f;
	//	foodbank1.color = temp;



	

		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 1;

		c =GameObject.Find("Choose_Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 1;



		opening_text.SetActive (false);

		Opening_Values.selectedfood= _countries [item.Index].Value.Name;

		Debug.Log ("selectedfood" + Opening_Values.selectedfood);

		Opening_Values.selectedfoodstrength= int.Parse(_countries [item.Index].Value.Strength);
		Opening_Values.selectedfoodhealth= int.Parse(_countries [item.Index].Value.Health);
		Opening_Values.selectedfoodsmartness= int.Parse(_countries [item.Index].Value.Smartness);
		Opening_Values.selectedfoodfd= _countries [item.Index].Value.CodeAlpha3;



		if (StrengthScript.current_food != "") {
			foodbank1.sprite = Resources.Load<Sprite> ("flags/" + StrengthScript.current_food);
		}



			fd.GetComponent<Text>().text =_countries[item.Index].Value.CodeAlpha3;

		Opening_Values.selectedfoodfoodgroup = _countries [item.Index].Value.FoodGroups;
		food_group.GetComponent<Text>().text ="(" + _countries[item.Index].Value.FoodGroups + ")";

		health.GetComponent<Text>().text =_countries[item.Index].Value.Health;
		strength.GetComponent<Text>().text =_countries[item.Index].Value.Strength;

	//	strength.GetComponent<Text>().text =_countries[item.Index].Value.Strength;


		smartness.GetComponent<Text>().text =_countries[item.Index].Value.Smartness;

		AudioSource audio = gameObject.AddComponent<AudioSource>();
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

			foreach(AudioSource audioS in allAudioSources){
				audioS.Stop();
			}
	audio.PlayOneShot((AudioClip)Resources.Load("audio/" + _countries [item.Index].Value.Name));

	

			#if UNITY_EDITOR || DEVELOPMENT_BUILD
		Debug.Log("Selected Country | " + _countries[item.Index].Value.Name  + "sfsf" + _countries[item.Index].Value.CodeAlpha3)    ;
		#endif
	}

	void HandleOnItemLoadedHandler (ListItemBase item) // reference to the loaded list item
	{
		if(item == (ListItemCountry)_selectedItem)
		{
			_selectedItem.Select (_selectedIndex == _selectedItem.Index);	
		}

		ListItemCountry countryItem = (ListItemCountry)item;	// cast to your own ListItem
		countryItem.SetCode (_countries[item.Index].Key);
		countryItem.SetLabel (_countries[item.Index].Value.Name);
	}
}
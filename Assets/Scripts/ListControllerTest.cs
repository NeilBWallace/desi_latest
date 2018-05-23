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

public class ListControllerTest : MonoBehaviour
{

	private AudioSource[] allAudioSources;


	[SerializeField]
	private List _list;

	[SerializeField]
	private ListItemBase _listItem;


	private int _selectedIndex;

	private ListItemCountry _selectedItem;

	private List<KeyValuePair<string, Country>> _countries;


	void Start()
	{
		_countries = Countries.Dictionary.ToList ();

		_list.onItemLoaded = HandleOnItemLoadedHandler;		// called when an item is recycled
		_list.onItemSelected = HandleOnItemSelectedHandler;	// called when the item is selected

		_list.Create (_countries.Count, _listItem); // create the list with a number and a prefab
		_list.gameObject.SetActive (true);
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

		#if UNITY_EDITOR || DEVELOPMENT_BUILD
		Debug.Log("Selected Country | " + _countries[item.Index].Value.Name);
		#endif
		GameObject.Find ("Food_Image").GetComponent<CanvasGroup> ().alpha=1;
		Image i = GameObject.Find ("Food_Image").GetComponent<Image> ();


		i.sprite = Resources.Load<Sprite> ("flags/" + _countries[item.Index].Value.Name);



		Text t = GameObject.Find ("Food_Title").GetComponent<Text> ();
		t.text = _countries [item.Index].Value.Name;
	    GameObject.Find ("Food_Description").GetComponent<Text>().text =_countries[item.Index].Value.CodeAlpha3;

		Opening_Values.selectedfood=_countries [item.Index].Value.Name;


		AudioSource audio = gameObject.AddComponent<AudioSource>();
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

		foreach(AudioSource audioS in allAudioSources){
			audioS.Stop();
		}
		audio.PlayOneShot((AudioClip)Resources.Load("audio/" + _countries [item.Index].Value.Name));

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
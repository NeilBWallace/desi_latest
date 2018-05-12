using UnityEngine;
using UnityEngine.UI;
public class ItemPickup : Interactable {

//	[SerializeField]
//	public GameObject eat_food_panel;

	[SerializeField]
public Text name;

//	[SerializeField]
//	private Text health;
//	[SerializeField]
//	private Text strength;
//	[SerializeField]
//	private Text smartness;


	//[SerializeField]
	//private Image foodbank1;

//	[SerializeField]
//	private Text food_group;



//	[SerializeField]
//	private Text food_description;

//	[SerializeField]
//	private Image food;

	//private GameObject myCanvas;
	//public Item item;	// Item to put in the inventory on pickup

	// When the player interacts with the item
	public override void Interact()
	{
		base.Interact();

		PickUp();	// Pick it up!
	}

	public Opening_Values o;
	// Pick up the item
	void PickUp ()
	{

		GameObject.Find ("Food_Sound").GetComponent<AudioSource> ().Play ();
	

		Debug.Log ("2222");
		Debug.Log ("pickupp" + gameObject.name);
		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 1;
	 c =GameObject.Find("Eat_Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 1;
	//	 Opening_Values.move =0;
	//	food_panel.SetActive (true);	
	//	eat_food_panel.SetActive (true);
	//	item.name = name;

		Text t = GameObject.Find ("food_title1").GetComponent<Text> ();
		t.text= gameObject.name;

		Image i = GameObject.Find ("foodbank").GetComponent<Image> ();

		i.sprite = Resources.Load<Sprite> ("flags/" +gameObject.name);

		Text g = GameObject.Find ("fd").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().fd.ToString();

		g = GameObject.Find ("strength").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().strength.ToString();


		g = GameObject.Find ("health").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().health.ToString();

		g = GameObject.Find ("smartness").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().smartness.ToString();

		g = GameObject.Find ("food_group").GetComponent<Text> ();
		g.text =GameObject.Find (gameObject.name).GetComponent<stats>().food_group.ToString();

	//	food_title1.GetComponent<Text> ().text = item.name;
	//	health.text = item.health.ToString();
	//	strength.text = item.strength.ToString();
	//	smartness.text = item.smartness.ToString();
	//	food_description.text = item.fd;
	//	Debug.Log("Picking up item" + item.name + " " + item.health + " " + item.strength + " " + item.smartness + item.fd);
	//	bool wasPickedUp = Inventory.instance.Add(item);	// Add to inventory


		 


		// If successfully picked up
//		if (wasPickedUp)
		//Destroy(gameObject);	// Destroy item from scene
	}

}

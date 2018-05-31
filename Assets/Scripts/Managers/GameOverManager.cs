using UnityEngine;

namespace CompleteProject
{
	public class GameOverManager : MonoBehaviour
	{
		public PlayerHealth playerHealth;       // Reference to the player's health.


		Animator anim;                          // Reference to the animator component.


		void Awake ()
		{
			// Set up the reference.
			anim = GetComponent <Animator> ();
		}


		void Update ()
		{
			if (Application.loadedLevelName == "parental_setup") {
				if (ScoreManager.score == Opening_Values.foods_chosen) {	
					Application.LoadLevel (7);
				} 
			}else if (ScoreManager.score == 4) {
				Application.LoadLevel (7);
			}

			// If the player has run out of health...
			if(playerHealth.currentHealth <= 0)
			{
				// ... tell the animator the game is over.
				anim.SetTrigger ("GameOver");
			}
		}
	}
}


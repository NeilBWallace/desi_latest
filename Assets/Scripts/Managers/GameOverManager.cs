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

			if (ScoreManager.score == 4) {
				Application.LoadLevel (1);
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


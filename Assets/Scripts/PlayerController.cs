

using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
	
	Camera cam;
	public LayerMask movementMask;
	public Animation anim;
	public Interactable focus;
	PlayerMotor motor;





	// Set our focus to a new focus
	void SetFocus (Interactable newFocus)
	{
		// If our focus has changed
		if (newFocus != focus)
		{
			// Defocus the old one
			if (focus != null)
				focus.OnDefocused();

			focus = newFocus;	// Set our new focus
			motor.FollowTarget(newFocus);	// Follow the new focus
		}

		newFocus.OnFocused(transform);
	}

	// Remove our current focus
	void RemoveFocus ()
	{
		if (focus != null)
			focus.OnDefocused();

		focus = null;
		motor.StopFollowingTarget();

	}




	void Start(){
		anim = GetComponent<Animation>();
		cam =Camera.main;
		motor = GetComponent<PlayerMotor> ();
	}
	void Update ()
	{


		if (Input.GetMouseButtonDown (0)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
		//		if (Opening_Values.move == 1) {
					motor.MoveToPoint (hit.point);
		//		}
				//	Debug.Log ("we hit" + hit.collider.name + " " + hit.point);
			
		
		

				Interactable interactable = hit.collider.GetComponent<Interactable> ();

				if (interactable != null) {
					SetFocus (interactable);
					//	}
					//	var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
					//	var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
					//	var walkSpeed = Input.GetAxis ("Vertical");
					//	Debug.Log ("rotation" + x);
					//	Debug.Log (walkSpeed);

				
				
				}	

			}
	

			//	transform.Rotate(0, x, 0);
			//	transform.Translate(0, 0, z);

	
		}
	}
}



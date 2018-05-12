using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour {

    const float locomationAnimationSmoothTime = .1f;

    NavMeshAgent agent;
    Animator animator;
	public Animation anim;
	void Start () {
		Debug.Log ("start");
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
	}
	
	void Update () {
		//Debug.Log ("update");
        float speedPercent = agent.velocity.magnitude / agent.speed;
		//Debug.Log ("xxx" + speedPercent);
     //   animator.SetFloat("speedPercent", speedPercent, locomationAnimationSmoothTime, Time.deltaTime);

		if ((Mathf.Abs (speedPercent) > 0.01))  {

			anim.Play ("Desi_stand");
		} else {
			anim.Stop ("Desi_stand");
		}
	}
}

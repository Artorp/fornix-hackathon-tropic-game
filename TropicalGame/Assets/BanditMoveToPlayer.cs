using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditMoveToPlayer : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
		animator = GetComponent<Animator>();
		animator.StartPlayback();
		Idle();
    }

    // Update is called once per frame
    void Update()
    {

	}

	public void Idle() {
		animator = GetComponent<Animator>();
		animator.SetBool("Walk", false);
		animator.SetBool("SprintJump", false);
		animator.SetBool("SprintSlide", false);
	}

	public void Walk() {
		animator = GetComponent<Animator>();
		animator.SetBool("Walk", true);
		animator.SetBool("SprintJump", false);
		animator.SetBool("SprintSlide", false);
	}

	public void SprintJump() {
		animator = GetComponent<Animator>();
		animator.SetBool("Walk", false);
		animator.SetBool("SprintJump", true);
		animator.SetBool("SprintSlide", false);
	}

	public void SprintSlide() {
		animator = GetComponent<Animator>();
		animator.SetBool("Walk", false);
		animator.SetBool("SprintJump", false);
		animator.SetBool("SprintSlide", true);
	}
}

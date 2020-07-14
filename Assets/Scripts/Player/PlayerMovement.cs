using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	public Joystick joystick;
	// Update is called once per frame
	void Update () {


		//if (joystick.Horizontal >= .2f)
		//{
		//	horizontalMove = runSpeed;

		//}
		//else if (joystick.Horizontal <= -.2f)
		//{
		//	horizontalMove = -runSpeed;
		//}
		//else
		//{
		//	horizontalMove = 0f;
		//}

		float verticalMove = joystick.Vertical;






		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if ( verticalMove>=.5f || Input.GetKeyDown(KeyCode.UpArrow))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

	}

	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}

	void FixedUpdate ()
	{
		// Move character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);

		jump = false;
	}
}

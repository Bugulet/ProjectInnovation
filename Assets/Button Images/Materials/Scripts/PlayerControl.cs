using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	public float speed;
	public float rotSpeed;
	public float JumpHeight;
	bool isGrounded;
	Rigidbody rb;

	bool moveF = false;
	bool moveB = false;
	bool moveR = false;
	bool moveL = false;
	bool jump = false;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.centerOfMass = Vector3.zero;
		rb.inertiaTensorRotation = Quaternion.identity;
	}

	private void FixedUpdate()
	{
		if (isGrounded == true && jump == true)
		{
			rb.AddForce(new Vector3(0, JumpHeight, 0));
			isGrounded = false;
		}

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
		{
			rb.AddForce(new Vector3(0, JumpHeight, 0));
			isGrounded = false;
		}

		float z = Input.GetAxis("Vertical") * (speed / 1000);
		float y = Input.GetAxis("Horizontal") * rotSpeed;
		transform.Translate(0, 0, z);
		transform.Rotate(0, y, 0);

		if (moveF) { transform.Translate(0, 0, speed / 1000); }
		else { transform.Translate(Vector3.zero); }

		if (moveB) { transform.Translate(0, 0, -speed / 1000); }
		else { transform.Translate(Vector3.zero); }

		if (moveR) { transform.Rotate(0, rotSpeed, 0); }
		else { transform.Rotate(Vector3.zero); }

		if (moveL) { transform.Rotate(0, -rotSpeed, 0); }
		else { transform.Rotate(Vector3.zero); }
	}

	public void rotateLeft()	{ moveL = true; }
	public void nRotateLeft()	{ moveL = false; }
	public void rotateRight()	{ moveR = true; }
	public void nRotateRight()	{ moveR = false; }
	public void moveForward()	{ moveF = true; }
	public void nMoveForward()	{ moveF = false; }
	public void moveBackward()	{ moveB = true; }	
	public void nMoveBackward()	{ moveB = false; }
	public void Jump()			{ jump = true; }
	public void nJump()			{ jump = false; }

	void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Panel")
		{
			isGrounded = true;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
	}
}

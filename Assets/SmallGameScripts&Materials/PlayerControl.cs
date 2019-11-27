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
	bool moveR = false;
	bool moveL = false;
	bool jump = false;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.centerOfMass = Vector3.zero;
		rb.inertiaTensorRotation = Quaternion.identity;
	}

	private void Update()
	{
		
	}

	private void FixedUpdate()
	{
		if (isGrounded == true && jump == true)
		{
			rb.AddForce(new Vector3(0, JumpHeight, 0));
			isGrounded = false;
		}

		float z = Input.GetAxis("Vertical") * (speed / 1000);
		float y = Input.GetAxis("Horizontal") * rotSpeed;
		//transform.Translate(0, 0, z);
		//transform.Rotate(0, y, 0);

		if (moveF) { transform.Translate(0, 0, speed / 1000); }
		else { transform.Translate(Vector3.zero); }

		if (moveR) { transform.Rotate(0, rotSpeed, 0); }
		else { transform.Rotate(Vector3.zero); }

		if (moveL) { transform.Rotate(0, -rotSpeed, 0); }
		else { transform.Rotate(Vector3.zero); }
	}

	public void rotateLeft()
	{
		//transform.Rotate(0, -1 * rotSpeed,0);
		moveL = true;
	}

	public void rotateRight()
	{
		//transform.Rotate(0, 1 * rotSpeed, 0);
		moveR = true;
	}

	public void moveForward()
	{
		//transform.Translate(0, 0, speed/1000);
		moveF = true;
	}

	public void nRotateLeft()
	{ moveL = false; }

	public void nRotateRight()
	{ moveR = false; }

	public void nMoveForward()
	{ moveF = false; }

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

	public void Jump()
	{
		jump = true;	
	}

	public void nJump()
	{
		jump = false;
	}

}

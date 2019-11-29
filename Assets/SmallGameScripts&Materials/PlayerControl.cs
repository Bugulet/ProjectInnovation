using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	public float speed;
	public float rotSpeed;
	public float JumpHeight;
	bool isGrounded;
	public float GravityStrength;
	Rigidbody rb;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.centerOfMass = Vector3.zero;
		rb.inertiaTensorRotation = Quaternion.identity;
		isGrounded = true;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
		{
			Jump();
		}
	}

	private void FixedUpdate()
	{
		Vector3 gravityS = new Vector3(0, GravityStrength, 0);
		Physics.gravity = gravityS;

		float z = Input.GetAxis("Vertical") * speed;
		float y = Input.GetAxis("Horizontal") * rotSpeed;

		transform.Translate(0, 0, z);
		transform.Rotate(0, y, 0);

		
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Panel" || collision.gameObject.tag == "Ground")
		{
			isGrounded = true;
		}

	}

	void Jump()
	{
		rb.AddForce(new Vector3(0, JumpHeight, 0));
		isGrounded = false;
	}

	//void OnCollisionEnter()
	//{
	//	isGrounded = true;
	//}
	//Rigidbody player;
	//float m_Speed;

	//private void Start()
	//{
	//	player = GetComponent<Rigidbody>();
	//	m_Speed = 10.0f;
	//}

	//void Update()
	//{
	//	if (Input.GetKey(KeyCode.UpArrow))
	//	{
	//		player.velocity = transform.forward * m_Speed;
	//	}

	//	if (Input.GetKey(KeyCode.DownArrow))
	//	{
	//		player.velocity = -transform.forward * m_Speed;
	//	}

	//	if (player.velocity.y == 0 && Input.GetKeyDown(KeyCode.Space))
	//	{
	//		player.velocity = transform.up * m_Speed;
	//	}

	//	if (Input.GetKey(KeyCode.RightArrow))
	//	{
	//		transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Speed * 10, Space.World);
	//	}

	//	if (Input.GetKey(KeyCode.LeftArrow))
	//	{
	//		transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * m_Speed * 10, Space.World);
	//	}
	//}
}

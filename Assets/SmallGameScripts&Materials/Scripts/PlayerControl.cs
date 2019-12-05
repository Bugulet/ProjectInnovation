using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
	Rigidbody rb;
	float speed = 5;
	float rotSpeed = 3;
	float JumpHeight = 200;
	float groundDistance;
	float score;
	bool isGrounded = false;
	bool moveF = false;
	bool moveB = false;
	bool moveR = false;
	bool moveL = false;
	bool jump = false;
	bool hasCollectedEngineerToken = false;
	bool hasCollectedArtistToken = false;
	bool hasCollectedDesignerToken = false;
	bool checkPoint01 = false;
	bool checkPoint02 = false;
	bool checkPoint03 = false;
	bool checkPoint04 = false;
	bool checkPoint05 = false;
	bool checkPoint06 = false;
	bool checkPoint07 = false;
	bool checkPoint08 = false;
	bool checkPoint09 = false;

	public Text scoreText;
	public Text highScore;
	public Renderer playerDeafultRenderer;
	public GameObject playerModel;
	public GameObject otherControls;
	public GameObject DesignerPlatforms;
	public GameObject artistPlatforms;
	public GameObject defaultPlatforms;
	public GameObject EngineerCheckPoint;
	public GameObject ArtistCheckPoint;
	public GameObject DesignerCheckpoint;
	public GameObject engineerPopUpText;
	public GameObject artistPopUpText;
	public GameObject designerPopUpText;
	public GameObject endgamePopUpText;
	public GameObject scoreTextPopUp;
	public GameObject checkP01;
	public GameObject checkP02;
	public GameObject checkP03;
	public GameObject checkP04;
	public GameObject checkP05;
	public GameObject checkP06;
	public GameObject checkP07;
	public GameObject checkP08;
	public GameObject checkP09;

	public GameObject[] coins = new GameObject[12];

	Vector3 engineerCHPposition;
	Vector3 artistCHPposition;
	Vector3 designerCHPposition;

	Vector3 checkPoint1position, checkPoint2position, checkPoint3position, checkPoint4position, checkPoint5position,
			checkPoint6position, checkPoint7position, checkPoint8position, checkPoint9position;

	private void Start()
	{
		score = 0;
		playerDeafultRenderer = GetComponent<Renderer>();
		playerDeafultRenderer.enabled = true;
		rb = GetComponent<Rigidbody>();
		rb.centerOfMass = Vector3.zero;
		rb.inertiaTensorRotation = Quaternion.identity;
		groundDistance = GetComponent<Collider>().bounds.extents.y;
		engineerCHPposition = EngineerCheckPoint.transform.position;
		artistCHPposition = ArtistCheckPoint.transform.position;
		designerCHPposition = DesignerCheckpoint.transform.position;
		checkPoint1position = checkP01.transform.position;
		checkPoint2position = checkP02.transform.position;
		checkPoint3position = checkP03.transform.position;
		checkPoint4position = checkP04.transform.position;
		checkPoint5position = checkP05.transform.position;
		checkPoint6position = checkP06.transform.position;
		checkPoint7position = checkP07.transform.position;
		checkPoint8position = checkP08.transform.position;
		checkPoint9position = checkP09.transform.position;
	}

	private void FixedUpdate()
	{
		scoreText.text = "Score: " + score.ToString();

		if (!Physics.Raycast(transform.position, -Vector3.up, groundDistance))
		{   isGrounded = false; }
		else
		{	isGrounded = true; }

		if (isGrounded == true && jump == true) { rb.AddForce(0, JumpHeight / 100, 0, ForceMode.Impulse); }

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

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Lava")
		{
			if (checkPoint09) { rb.transform.position = checkPoint9position; }
			else if (checkPoint08) { rb.transform.position = checkPoint8position; }
			else if (checkPoint07) { rb.transform.position = checkPoint7position; }
			else if (checkPoint06) { rb.transform.position = checkPoint6position; }
			else if (checkPoint05) { rb.transform.position = checkPoint5position; }
			else if (checkPoint04) { rb.transform.position = checkPoint4position; }
			else if (hasCollectedDesignerToken)
			{
				rb.transform.position = designerCHPposition;
				score = 0;
				foreach (GameObject coin in coins)
				{
					coin.SetActive(true);
				}
			}
			else if (checkPoint03) { rb.transform.position = checkPoint3position; }
			else if (hasCollectedArtistToken) { rb.transform.position = artistCHPposition; }
			else if (checkPoint02) { rb.transform.position = checkPoint2position; }
			else if (checkPoint01) { rb.transform.position = checkPoint1position; }
			else if (hasCollectedEngineerToken) { rb.transform.position = engineerCHPposition; }
			else { rb.transform.position = new Vector3(-0.441f, 0.0238f, -0.4377f); }
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "EngineerToken")
		{	engineerPopUpText.SetActive(true);
			otherControls.SetActive(true);
			hasCollectedEngineerToken = true;
			Destroy(other.gameObject); }

		if (other.gameObject.tag == "ArtistToken")
		{	artistPopUpText.SetActive(true);
			defaultPlatforms.SetActive(false);
			artistPlatforms.SetActive(true);
			playerDeafultRenderer.enabled = false;
			playerModel.SetActive(true);
			hasCollectedArtistToken = true;
			Destroy(other.gameObject); }

		if (other.gameObject.tag == "DesignerToken")
		{	designerPopUpText.SetActive(true);
			DesignerPlatforms.SetActive(true);
			scoreTextPopUp.SetActive(true);
			hasCollectedDesignerToken = true;
			Destroy(other.gameObject); }

		if (other.gameObject.tag == "Princess")
		{	endgamePopUpText.SetActive(true);
			scoreTextPopUp.SetActive(false);
			highScore.text = "Highscore: " + score.ToString(); }

		if (other.gameObject.tag == "Coin100") { score += 100; other.gameObject.SetActive(false); }
		if (other.gameObject.tag == "Coin10") {	score += 10; other.gameObject.SetActive(false); }
		if (other.gameObject.tag == "CheckPoint01") { checkPoint01 = true; }
		else if (other.gameObject.tag == "CheckPoint02") { checkPoint02 = true; }
		else if (other.gameObject.tag == "CheckPoint03") { checkPoint03 = true; }
		else if (other.gameObject.tag == "CheckPoint04") { checkPoint04 = true; }
		else if (other.gameObject.tag == "CheckPoint05") { checkPoint05 = true; }
		else if (other.gameObject.tag == "CheckPoint06") { checkPoint06 = true; }
		else if (other.gameObject.tag == "CheckPoint07") { checkPoint07 = true; }
		else if (other.gameObject.tag == "CheckPoint08") { checkPoint08 = true; }
		else if (other.gameObject.tag == "CheckPoint09") { checkPoint09 = true; }
	}
}

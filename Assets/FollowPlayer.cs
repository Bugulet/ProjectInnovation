using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class FollowPlayer : MonoBehaviour
//{
//	public Transform PlayerTransfrom;
//	public Vector3 _cameraOffset;
//	[Range(0.01f, 1.0f)]
//	public float SmoothFactor = 0.5f;

//	float rotateOffset;
//    // Start is called before the first frame update
//    void Start()
//    {
//		_cameraOffset = transform.position - PlayerTransfrom.position;
//    }

//	private void LateUpdate()
//	{
//		rotateOffset = PlayerTransfrom.rotation.y;
//		Vector3 newPos = PlayerTransfrom.position + _cameraOffset;

//		//transform.RotateAround(Vector3., rotateOffset);
//		transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

//	}
//}

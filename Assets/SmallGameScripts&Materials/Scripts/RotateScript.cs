using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
	private void Update()
	{
		transform.Rotate(new Vector3(0, 0, -90.0f) * Time.deltaTime);
	}
}

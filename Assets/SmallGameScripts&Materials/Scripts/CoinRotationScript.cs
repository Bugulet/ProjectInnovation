using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotationScript : MonoBehaviour
{
	private void Update()
	{
		transform.Rotate(new Vector3(0, 60.0f, 0) * Time.deltaTime);
	}
}

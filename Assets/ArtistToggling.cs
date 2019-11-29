using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtistToggling : MonoBehaviour
{
	public GameObject deafultAssets;
	public GameObject finalAssets;

	private bool deafultIsOn;

	private void Start()
	{
		deafultIsOn = false;
	}

	private void Update()
	{
		if (deafultIsOn)
		{
			deafultAssets.SetActive(true);
			finalAssets.SetActive(false);
		}
		else
		{
			deafultAssets.SetActive(false);
			finalAssets.SetActive(true);
		}
	}

	public void Switch()
	{
		deafultIsOn = !deafultIsOn;
	}
}

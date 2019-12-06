using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collided : MonoBehaviour
{
    [SerializeField] private GameObject nextButton;


    private void OnTriggerEnter(Collider other)
    {
        nextButton.SetActive(true);
        print("HUHH");
    }
}

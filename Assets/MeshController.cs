using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshController : MonoBehaviour
{

    [SerializeField]
    GameObject textHolder, explanationHolder;

    int currentCube=0;


    public void increaseCube()
    {
        currentCube++;
        if (currentCube >=transform.childCount) currentCube =transform.childCount-1;

        ChangeCube();
    }

    public void decreaseCube()
    {
        currentCube--;
        if (currentCube <0) currentCube = 0;

        ChangeCube();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void ChangeCube()
    {
        for (int i = 0; i < textHolder.transform.childCount; i++)
        {
            if (currentCube == i)
            {
                textHolder.transform.GetChild(i).gameObject.SetActive(true);
                explanationHolder.transform.GetChild(i).gameObject.SetActive(true);

                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                textHolder.transform.GetChild(i).gameObject.SetActive(false);
                explanationHolder.transform.GetChild(i).gameObject.SetActive(false);

                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

}

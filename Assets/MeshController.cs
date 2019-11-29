using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshController : MonoBehaviour
{

    [SerializeField]
    GameObject textWire, textFlat, textTex, cubeWire, cubeFlat, cubeTex;

    int currentCube=0;


    public void increaseCube()
    {
        currentCube++;
        if (currentCube > 2) currentCube = 2;
    }

    public void decreaseCube()
    {
        currentCube--;
        if (currentCube <0) currentCube = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentCube)
        {
            case 0:
                textWire.SetActive(true);
                cubeWire.SetActive(true);

                textFlat.SetActive(false);
                cubeFlat.SetActive(false);

                textTex.SetActive(false);
                cubeTex.SetActive(false);

                break;

            case 1:
                textWire.SetActive(false);
                cubeWire.SetActive(false);

                textFlat.SetActive(true);
                cubeFlat.SetActive(true);

                textTex.SetActive(false);
                cubeTex.SetActive(false);

                break;

            case 2:
                textWire.SetActive(false);
                cubeWire.SetActive(false);
                                   
                textFlat.SetActive(false);
                cubeFlat.SetActive(false);

                textTex.SetActive(true);
                cubeTex.SetActive(true);

                break;

            default:
                break;
        }
    }
}

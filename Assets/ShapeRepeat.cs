using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeRepeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    float shapeKey = 1;

    float adding = 3f;
    // Update is called once per frame
    void Update()
    {
        if (shapeKey >= 100 || shapeKey<=0)
        {
            adding *= -1;
        }
        shapeKey += adding;
        GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, shapeKey);
    }   

    
}

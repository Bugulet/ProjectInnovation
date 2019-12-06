using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour
{
    int currentLevel = 0;
    [SerializeField] private GameObject levelObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextLevel()
    {
        currentLevel++;
        for (int i = 0; i < levelObject.transform.childCount; i++)
        {
            if (i == currentLevel)
            {
                levelObject.transform.GetChild(i).gameObject.SetActive(true);

            }
            else
            {
                levelObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

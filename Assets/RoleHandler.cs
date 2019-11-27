using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleHandler : MonoBehaviour
{
    [SerializeField]
    private RoleSelected role;

    [SerializeField]
    private GameObject handlerObject;

    private int ActiveInformation = 0;


    [SerializeField]
    private GameObject dropDown;

    private PosterEvents posterHandler;

    private bool isSelected = false;

    // Start is called before the first frame update



    void Start()
    {

        dropDown.SetActive(false);

        posterHandler = handlerObject.GetComponent<PosterEvents>();
    }

    // Update is called once per frame
    void Update()
    {
        if (role == RoleSelected.GameDetails)
        {
            if (posterHandler.role == role)
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            else
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }
        //else if it is anything else other than the game details
        else
        {
            if (posterHandler.role == role)
            {
                //code here
                dropDown.SetActive(true);
                for (int i = 0; i < transform.childCount; i++)
                {
                    if (i == ActiveInformation)
                    {
                        transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(i).gameObject.SetActive(false);
                    }
                }

            }
            else
            {
                ActiveInformation = 0;
                dropDown.SetActive(false);
                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }

    }

    public void SetInformation(int index)
    {
        Debug.Log("information changed to" + index);
        ActiveInformation = index;
    }

}

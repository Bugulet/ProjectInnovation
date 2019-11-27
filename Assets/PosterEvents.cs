using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum RoleSelected
{
    Artist, Designer, Engineer,GameDetails, Unselected
}

public class PosterEvents : MonoBehaviour
{
    public GameObject RoleSelection, ToggleButton,ChangeRoleButton;
    

    [HideInInspector]
    public RoleSelected role;

    void Start()
    {
        SetRole(RoleSelected.Unselected);

        RoleSelection.SetActive(false);
        ChangeRoleButton.SetActive(false);
    }

    public void SetToGameDetails() { SetRole(RoleSelected.GameDetails); }
    public void SetToEngineer(){ SetRole(RoleSelected.Engineer); }
    public void SetToDesigner() { SetRole(RoleSelected.Designer); }
    public void SetToArtist() { SetRole(RoleSelected.Artist); }
    public void ResetRole() { SetRole(RoleSelected.Unselected); }

    private void SetRole(RoleSelected _role)
    {
        role = _role;
    }

    public void ShowRoles()
    {
        RoleSelection.SetActive(true);
        ChangeRoleButton.SetActive(false);
    }

    public void HideRoles()
    {
        RoleSelection.SetActive(false);
        ChangeRoleButton.SetActive(true);
    }

    public void ShowToggleButton()
    {
        ToggleButton.SetActive(true);
    }

    public void HideToggleButton()
    {
        ToggleButton.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

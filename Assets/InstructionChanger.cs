using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionChanger : MonoBehaviour
{

    public Instructions instruction;

    private GameObject intermediateObject;

    [SerializeField] private GameObject instructionPanel;

    public void SetInstruction(int inst)
    {
        instruction =(Instructions) inst;
        intermediateObject.GetComponent<InstructionBlock>().instruction= instruction;
        intermediateObject.GetComponent<InstructionBlock>().SetName();
        HidePanels();
    }

    public Instructions GetInstructions()
    {
        return instruction;
    }

    public void ChangeObject(GameObject other)
    {
        intermediateObject = other;
        instructionPanel.SetActive(true);
    }

    public GameObject GetObject()
    {
        return intermediateObject;
    }

    public void HidePanels()
    {
        instructionPanel.SetActive(false);
    }
}

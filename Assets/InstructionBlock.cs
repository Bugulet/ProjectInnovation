using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum InstructionType { instruction, conditional, repeat }
public enum Conditions { blockInFront, holeInFront,none }
public enum Instructions { walk, jump, rotateLeft, rotateRight,none }

public class InstructionBlock : MonoBehaviour
{

    public InstructionType type;

    [HideInInspector]
    public Conditions condition=Conditions.none;

    [HideInInspector]
    public Instructions instruction=Instructions.none;

    public int repeatNum = 0;

    public void SetName()
    {
        transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = System.Enum.GetName(typeof(Instructions), instruction);
        
    }


}

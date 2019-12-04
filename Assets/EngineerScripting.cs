using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EngineerScripting : MonoBehaviour
{

    public GameObject[] blocks;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }

    private int level = 0;
    float timer = 0f;

    int insNum = 0;

    // Update is called once per frame
    void Update()
    {

        if (level == 1)
        {
            FirstLevel();
        }

        timer += Time.deltaTime;
    }

    public void SetLevel(int lev)
    {
        level = lev;
        timer = 0;
        insNum = 0;
    }

    public void FirstLevel()
    {
        // print(timer);
        if (timer >= 0.5f && insNum < 2)
        {
            timer = 0;

            Execute(blocks[insNum]);
            print(insNum);
            insNum++;
        }

    }

    private void Execute(GameObject block)
    {
        Instructions instruction = block.GetComponent<InstructionBlock>().instruction;

        if (instruction == Instructions.walk)
        {
            player.transform.Translate(Vector3.forward);
        }

        if (instruction == Instructions.rotateRight)
        {
            player.transform.Rotate(0, 90, 0);
        }

        if (instruction == Instructions.rotateLeft)
        {
            player.transform.Rotate(0, -90, 0);
        }
    }


}

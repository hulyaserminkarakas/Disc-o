using UnityEngine;
using System.Collections;
using System;

public class InputController : MonoBehaviour {

    public enum eSlectedBlock
    {
        None,
        Block1,
        Block2,
        Block3,
        Block4,
        Block5,
        Block6
    }

    private int[] blockTurn;

    void Awake()
    {
        blockTurn = new int[6];
        for (int i = 0; i < 6; i++)
        {
            blockTurn[i] = 3;
        }
    }

    eSlectedBlock selectedBlock = eSlectedBlock.None;

    // Use this for initialization
    void Update()
    {
        if (Input.GetKeyUp("1"))
        {
            selectedBlock = eSlectedBlock.Block1;
            print("1");
        }
        if (Input.GetKeyUp("2"))
        {
            selectedBlock = eSlectedBlock.Block2;
            print("2");
        }
        if (Input.GetKeyUp("3"))
        {
            selectedBlock = eSlectedBlock.Block3;
            print("3");
        }
        if (Input.GetKeyUp("4"))
        {
            selectedBlock = eSlectedBlock.Block4;
            print("4");
        }
        if (Input.GetKeyUp("5"))
        {
            selectedBlock = eSlectedBlock.Block5;
            print("5");
        }
        if (Input.GetKeyUp("6"))
        {
            selectedBlock = eSlectedBlock.Block6;
            print("6");
        }
        if (Input.GetKeyUp("right"))
        {
            if (selectedBlock == eSlectedBlock.Block1)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block1");
                SwapRight(block , 0);
                print("right");
            }
            else if (selectedBlock == eSlectedBlock.Block2)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block2");
                SwapRight(block, 1);
                print("right");
            }
            else if (selectedBlock == eSlectedBlock.Block3)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block3");
                SwapRight(block, 2);
                print("right");
            }
            else if (selectedBlock == eSlectedBlock.Block4)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block4");
                SwapRight(block, 3);
                print("right");
            }
            else if (selectedBlock == eSlectedBlock.Block5)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block5");
                SwapRight(block, 4);
                print("right");
            }
            else
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block6");
                SwapRight(block, 5);
                print("right");
            }
        }
        if (Input.GetKeyUp("left"))
        {
            if (selectedBlock == eSlectedBlock.Block1)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block1");
                SwapLeft(block, 0);
                print("left");
            }
            else if (selectedBlock == eSlectedBlock.Block2)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block2");
                SwapLeft(block, 1);
                print("left");
            }
            else if (selectedBlock == eSlectedBlock.Block3)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block3");
                SwapLeft(block, 2);
                print("left");
            }
            else if (selectedBlock == eSlectedBlock.Block4)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block4");
                SwapLeft(block, 3);
                print("left");
            }
            else if (selectedBlock == eSlectedBlock.Block5)
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block5");
                SwapLeft(block, 4);
                print("left");
            }
            else
            {
                GameObject block = GameObject.FindGameObjectWithTag("Block6");
                SwapLeft(block, 5);
                print("left");
            }
        }
    }

    /*
    private void SwapLeft(GameObject block, int index)
    {
        if (blockTurn[index] == -1)
        {
            Transform children1 = block.transform.GetChild(4);
            Transform children2 = block.transform.GetChild(0);
            blockTurn[index] = 3;
            SingleSwap(children1, children2);
        }
        else
        {
            Transform children1 = block.transform.GetChild(blockTurn[index]);
            Transform children2 = block.transform.GetChild(blockTurn[index] + 1);
            blockTurn[index] = blockTurn[index] + 1;
            SingleSwap(children1, children2);
        }
    }
    */
    void SwapRight(GameObject block , int index)
    {
        //blockTurn[index] == -1)
        
            Transform children0 = block.transform.GetChild(0);
            Transform children1 = block.transform.GetChild(1);
            Transform children2 = block.transform.GetChild(2);
            Transform children3 = block.transform.GetChild(3);
            Transform children4 = block.transform.GetChild(4);
            blockTurn[index] = 3;
            MoveBlocks(children0, children1, children2, children3, children4, "right");
        
        //else
        //{
        //    Transform children1 = block.transform.GetChild(blockTurn[index]);
        //    Transform children2 = block.transform.GetChild(blockTurn[index] + 1);
        //    blockTurn[index] = blockTurn[index] - 1;
        //    SingleSwap(children1, children2);
        //}
    }
    void SwapLeft(GameObject block, int index)
    {
        //blockTurn[index] == -1)

        Transform children0 = block.transform.GetChild(0);
        Transform children1 = block.transform.GetChild(1);
        Transform children2 = block.transform.GetChild(2);
        Transform children3 = block.transform.GetChild(3);
        Transform children4 = block.transform.GetChild(4);
        blockTurn[index] = 3;
        MoveBlocks(children0, children1, children2, children3, children4, "left");

        //else
        //{
        //    Transform children1 = block.transform.GetChild(blockTurn[index]);
        //    Transform children2 = block.transform.GetChild(blockTurn[index] + 1);
        //    blockTurn[index] = blockTurn[index] - 1;
        //    SingleSwap(children1, children2);
        //}
    }

    private void MoveBlocks(Transform children0, Transform children1, Transform children2, Transform children3, Transform children4, String way)
    {
        if (way == "left")
        {
            Vector3 tempPos = children0.position;
            Quaternion tempRot = children0.rotation;
            Transform temp = children0;

            children0.rotation = children1.rotation;
            children1.rotation = children2.rotation;
            children2.rotation = children3.rotation;
            children3.rotation = children4.rotation;
            children4.rotation = tempRot;

            children0.position = children1.position;
            children1.position = children2.position;
            children2.position = children3.position;
            children3.position = children4.position;
            children4.position = tempPos;

            children0 = children1;
            children1 = children2;
            children2 = children3;
            children3 = children4;
            children4 = temp;
        }
        else {

            Vector3 tempPos = children4.position;
            Quaternion tempRot = children4.rotation;
            Transform temp = children4;

            children4.rotation = children3.rotation;
            children3.rotation = children2.rotation;
            children2.rotation = children1.rotation;
            children1.rotation = children0.rotation;
            children0.rotation = tempRot;

            children4.position = children3.position;
            children3.position = children2.position;
            children2.position = children1.position;
            children1.position = children0.position;
            children0.position = tempPos;

            children4 = children3;
            children3 = children2;
            children2 = children1;
            children1 = children0;
            children0 = temp;
        }
    }

    void SingleSwap(Transform children1 , Transform children2)
    {
        Vector3 tempPos = children1.position;
        Quaternion tempRot = children1.rotation;

        Transform temp = children1;

        children1.rotation = children2.rotation;
        children1.position = children2.position;
        children1 = children2;

        children2.position = tempPos;
        children2.rotation = tempRot;
        children2 = temp;
    }
}

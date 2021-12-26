using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimCondition
{
    Idle, FirstWave 
}

public class Astronaut : MonoBehaviour
{ 
    [SerializeField] Animator animator;
    [SerializeField] Platform platform;
    
    private void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) ) && animator.GetInteger("animCond") == 0)
        { 
            animator.SetInteger("animCond", 1);
        }
    }

    void EndOfFirstWave()
    {
        if (platform.xPos != PositionX.Left)
        {
            animator.SetInteger("animCond", 10); // DIe Left
            Debug.Log("DIe Left");
        }
        else
        {
            animator.SetInteger("animCond", 2);
        }
        
    }
    void EndOfSecondWave()
    {
        if (platform.xPos != PositionX.Middle)
        {
            animator.SetInteger("animCond", 11); // DIe Middle
            Debug.Log("Dead Middle");
        }
        else
        {
            animator.SetInteger("animCond", 3);
        }
    }
    void EndOfThirdWave()
    {
        if (platform.xPos != PositionX.Right)
        {
            animator.SetInteger("animCond", 12); // DIe Right
            Debug.Log("DIe Right");
        }
        else
        {
            animator.SetInteger("animCond", 4);
        }
    }
    void Died()
    {
        Debug.Log("DIed finished, must go to idle");
        animator.SetInteger("animCond", 0);
    }
    void Dying()
    {
        Debug.Log("Dying process");
        animator.SetInteger("animCond", 22);
    }
    void EndOfToShip()
    {
        animator.SetInteger("animCond", 0);
    }
}

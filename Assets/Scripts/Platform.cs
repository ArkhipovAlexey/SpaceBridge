using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PositionX
{
    Left, Middle, Right
}
public class Platform : MonoBehaviour
{
    public PositionX xPos;
    const float xLeft = -4.2f;
    const float xMiddle = -0.5f;
    const float xRight = 3f;
    const float yPlatform = -2.7f;
    void Start()
    {
        xPos = PositionX.Left;
        transform.position = new Vector3(xLeft, yPlatform, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(xPos == PositionX.Middle)
            {
                xPos = PositionX.Left;
                transform.position = new Vector3(xLeft, yPlatform,0f);
            }
            else if(xPos == PositionX.Right)
            {
                xPos = PositionX.Middle;
                transform.position = new Vector3(xMiddle, yPlatform,0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(xPos == PositionX.Middle)
            {
                xPos = PositionX.Right;
                transform.position = new Vector3(xRight, yPlatform,0f);
            }
            else if(xPos == PositionX.Left)
            {
                xPos = PositionX.Middle;
                transform.position = new Vector3(xMiddle, yPlatform,0f);
            }
        }
    }
}

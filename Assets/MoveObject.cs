using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private GameObject objMove;

    public void setObjectMove(GameObject obj)
    {
        objMove = obj;
    }

    public void LeftRotateObj()
    {
        objMove.transform.Rotate(Vector3.up, Space.World);
    }

    public void RightRotateObj()
    {
        objMove.transform.Rotate(Vector3.down, Space.World);
    }

    public void UpRotateObj()
    {
        objMove.transform.Rotate(Vector3.left, Space.World);
    }

    public void DownRotateObj()
    {
        objMove.transform.Rotate(Vector3.right, Space.World);
    }

    public void AddScaleObj()
    {
        objMove.transform.localScale *= 1.1f; 
    }

    public void LessScaleObj()
    {
        objMove.transform.localScale /= 1.1f; 
    }

}

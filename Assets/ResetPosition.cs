using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 initialPosition = new Vector3(0,.21f, 0);
    public void Reset()
    {
        transform.position = initialPosition;
    }
}

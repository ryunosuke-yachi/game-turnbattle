using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGRotate1 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, -0.01f, 0));
    }
}
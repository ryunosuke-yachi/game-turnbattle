using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGRotate1 : MonoBehaviour
{
    [Header("Ž•ŽÔ‰ñ“]‘¬“x")]
    [SerializeField]
    float rotSpeed = 0.01f;
    void Update()
    {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }
}
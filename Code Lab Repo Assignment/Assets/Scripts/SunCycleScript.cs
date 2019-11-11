using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCycleScript : MonoBehaviour
{
    public float Speed;


    

    // Make sun and moon rotate around a central axis, creating effect of sunrise and set
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, Speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}

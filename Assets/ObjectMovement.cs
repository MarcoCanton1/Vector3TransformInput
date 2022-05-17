using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Vector3 movement;
    public Vector3 rotation;
    public Vector3 scale;
    public GameObject cube;
    
    void Start()
    {
        cube.transform.position = movement;
        cube.transform.eulerAngles = rotation;
        cube.transform.localScale = scale;
    }


    void Update()
    {
        
    }
}

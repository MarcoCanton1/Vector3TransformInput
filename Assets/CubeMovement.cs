using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Vector3 cubeMovement;
    

    
    void Start()
    {
        
    }


    void Update()
    {
        transform.position += cubeMovement;
    }
}

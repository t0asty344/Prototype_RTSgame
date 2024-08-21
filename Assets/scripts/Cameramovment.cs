using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Cameramovment : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frameeee
    void Update()
    {
        float target = Input.mouseScrollDelta.y;
        gameObject.transform.Rotate(target,0,0);

    }
}

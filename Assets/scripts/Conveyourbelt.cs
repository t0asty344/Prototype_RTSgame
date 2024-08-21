using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class Conveyourbelt : MonoBehaviour
{
    [SerializeField] float conveyourbeltspeed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        Vector3 move = rb.position;
        rb.position += transform.right*Time.fixedDeltaTime*conveyourbeltspeed;
        rb.MovePosition(move);
    }
    
}

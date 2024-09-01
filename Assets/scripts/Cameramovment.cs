using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Cameramovment : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera cinemachineVirtualCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frameeee
    void Update()
    {
        float target = Input.mouseScrollDelta.y;
        cinemachineVirtualCamera.m_Lens.FieldOfView +=target;

    }
}

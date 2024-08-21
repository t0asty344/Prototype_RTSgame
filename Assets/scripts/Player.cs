using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] float movementspeed = 10f;
  [SerializeField] float movespeedupdown = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }
    
    void Movement()
    {
        float left_right=Input.GetAxis("Vertical") * movementspeed *Time.deltaTime;
        float top_down=Input.GetAxis("Horizontal") * movementspeed *Time.deltaTime;
        transform.Translate(top_down,0,left_right);
        if(Input.GetKey(KeyCode.E))
        {
            gameObject.transform.position += new Vector3(0,-movespeedupdown *Time.deltaTime,0);

        }
        else if(Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.position += new Vector3(0,movespeedupdown*Time.deltaTime,0);
        }
    }

}
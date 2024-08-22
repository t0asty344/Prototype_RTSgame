using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor.Search;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] float movementspeed = 10f;
  [SerializeField] float movespeedupdown = 10f;
    [SerializeField]GameObject curentobject;
    [SerializeField] Camera camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Spawn();
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
    void Spawn()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            Transform bases =curentobject.GetComponentInChildren<Transform>().Find("Base");
            float x=bases.localScale.y/2;
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) {
                    if(hit.transform.CompareTag("Floor"))
                    {
                    Transform objectHit = hit.transform;
                            //Debug.Log();
                    Instantiate(curentobject,new Vector3(hit.point.x,hit.point.y+x,hit.point.z),Quaternion.identity);
                    }
                // Do something with the object that was hit by the raycast.
            }
           
        }
    }

}
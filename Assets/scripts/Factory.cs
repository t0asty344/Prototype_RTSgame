using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] GameObject spawnpoint;
    float timertime =5f;

    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        timer();
    }

    void timer()
    {
        timertime -= Time.deltaTime;
        if(timertime <=0f)
        {
            Instantiate(cube,spawnpoint.transform.position,Quaternion.identity);
            timertime=5f;
        }
    }
}

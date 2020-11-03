using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Random = UnityEngine.Random;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    public float tMax = 1;
    public float tStart = 0;
    public GameObject obstacule;
    public float obsHeight;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObstacule = Instantiate(obstacule);
        newObstacule.transform.position = transform.position + new Vector3 (0, 0, 0);
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if(tStart > tMax)
        {
            GameObject newObstacule = Instantiate(obstacule);
            newObstacule.transform.position = transform.position + new Vector3 (0, Random.Range(-obsHeight,obsHeight), 0);
            Destroy(gameObject, 10);
            tStart = 0;

        }
        else
        {
            tStart += Time.deltaTime;
        }
    }
}

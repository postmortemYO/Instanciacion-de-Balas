using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject MyPrefab;
    void Start()
    {
        InvokeRepeating("Ca�on", 1f, 1.5f);
        
    }


    void Update()
    {
        
    }

    void Ca�on()
    {
        Instantiate(MyPrefab, transform);
    }
}

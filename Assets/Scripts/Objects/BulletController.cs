using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float BulletSpeed = 1f;
    public float damage = 10f;
    public Vector3 direction;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(BulletSpeed * direction * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            float n = Random.Range(20, 50);
            this.rotSpeed = n;
        }
        transform.Rotate(0f, 0f, rotSpeed);
        this.rotSpeed *= 0.99f;
    }

    
}

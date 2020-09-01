﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggerColision : MonoBehaviour
{
    private Vector3 startPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        transform.position = startPosition;
    }
}

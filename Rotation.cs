﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float Rotazione = 50.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Rotazione * Time.deltaTime);
        // FILE MODIFICATO PER PROVARE AGGIORNAMENTO SU REPOSITORY IN GITHUB
    }
}
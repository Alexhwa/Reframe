﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject firstText;
    public GameObject SecondText;
    void Start()
    {
        
    }

            // Update is called once per frame
            void Update()
    {
        if (Input.GetKey("h"))
        {
            Destroy(firstText);
        }
        if (Input.GetKey("j"))
        {
            Destroy(SecondText);
        }
    }
}

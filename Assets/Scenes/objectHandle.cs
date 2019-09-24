﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class objectHandle : MonoBehaviour
{
    public GameObject control;
    // Start is called before the first frame update
    void Start()
    {
        //code for accessing the controller components
        
    }

    // Update is called once per frame
    void Update()
    {
        bool hitbox = control.GetComponent<controlCode>().map_hit_box;
        bool vis = control.GetComponent<controlCode>().map_visible;
        if (string.Equals(tag, "Ground"))
        {
            if (vis)
            {
                Renderer mesh = gameObject.GetComponent<Renderer>();
                mesh.enabled = true;
            }
            else
            {
                Renderer mesh = gameObject.GetComponent<Renderer>();
                mesh.enabled = false;
            }
            BoxCollider2D[] colliders = gameObject.GetComponentsInChildren<BoxCollider2D>();
            if (hitbox)
            {
                print("update true working");
                for(int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].enabled == true)
                    {
                        break;
                    }
                    colliders[i].enabled = true;
                }
            }
            else
            {
                print("update false working");
                for (int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].enabled == false)
                    {
                        break;
                    }
                    colliders[i].enabled = false;
                }
            }
        }
    }
}

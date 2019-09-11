using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHandle : MonoBehaviour
{
    public GameObject control;
    // Start is called before the first frame update
    void Start()
    {
        //code for accessing the controller components
        bool vis = control.GetComponent<controlCode>().map_visible;
        bool hitbox = control.GetComponent<controlCode>().map_hit_box;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

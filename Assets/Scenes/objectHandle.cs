using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHandle : MonoBehaviour
{
    public GameObject control;
    // Start is called before the first frame update
    void Start()
    {
        control = GameObject.Find("Controller");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

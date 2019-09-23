using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Display : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text txt = gameObject.GetComponent<Text>();
        txt.text = "Current score: " + PlayerPrefs.GetInt("num_coins", 0);
    }
}

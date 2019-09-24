using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt(name, 0) == 1)
        {
            //Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt(name, 1);
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) + 1);
            Destroy(gameObject);
        }
    }
}

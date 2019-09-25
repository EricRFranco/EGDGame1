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
            Renderer mesh = gameObject.GetComponent<Renderer>();
            mesh.enabled = false;
            Collider2D box = gameObject.GetComponent<Collider2D>();
            box.enabled = false;
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
            Renderer mesh = gameObject.GetComponent<Renderer>();
            mesh.enabled = false;
            Collider2D box = gameObject.GetComponent<Collider2D>();
            box.enabled = false;
            if (PlayerPrefs.GetInt("sound", 0) == 1)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
            }
        }
    }
}

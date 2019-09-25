using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCode : MonoBehaviour
{

    

    public int num_coins = 0;
    public int num_points = 0;
    public bool map_visible = false;
    public bool map_hit_box = false;
    public bool can_jump = false;
    public bool can_move = false;
    public bool bought_player = false;
    public bool plats = false;
    public bool goal = false;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("sound", 0) == 1)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
        if (PlayerPrefs.GetInt("player", 0) == 1)
        {
            bought_player = true;
        }
        if (PlayerPrefs.GetInt("map", 0) == 1)
        {
            map_visible = true;
        }
        if (PlayerPrefs.GetInt("hitbox", 0) == 1)
        {
            print("hotbox working");
            map_hit_box = true;
        }
        if (PlayerPrefs.GetInt("plats", 0) == 1)
        {
            plats = true;
        }
        if(PlayerPrefs.GetInt("run", 0) == 1)
        {
            can_move = true;
        }
        if(PlayerPrefs.GetInt("jump", 0) == 1)
        {
            can_jump = true;
        }
        if (PlayerPrefs.GetInt("goal", 0) == 1)
        {
            goal = true;
        }
        if (PlayerPrefs.GetInt("music", 0) == 1)
        {
            goal = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

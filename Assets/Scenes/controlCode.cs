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
    public bool platform_vis = false;
    public bool platform_hit = false;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("player", 0) == 0)
        {

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
        if (PlayerPrefs.GetInt("vis_plat", 0) == 1)
        {
            platform_vis = true;
        }
        if (PlayerPrefs.GetInt("box_plat", 0) == 1)
        {
            platform_hit = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    private void Start()
    {
       
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Player()
    {
        if (PlayerPrefs.GetInt("player", 0) == 0 && PlayerPrefs.GetInt("num_coins", 0)>=5)
        {
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) - 5);
            PlayerPrefs.DeleteKey("player");
            PlayerPrefs.SetInt("player", 1);
        }
    }
    public void Map()
    {
        if (PlayerPrefs.GetInt("map", 1) == 0 && PlayerPrefs.GetInt("num_coins", 0) >= 1)
        {
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) - 1);
            PlayerPrefs.DeleteKey("map");
            PlayerPrefs.SetInt("map", 1);
        }
    }
    public void Hitbox()
    {
        if (PlayerPrefs.GetInt("hitbox", 1) == 0 && PlayerPrefs.GetInt("num_coins", 0) >= 1)
        {
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) - 1);
            PlayerPrefs.DeleteKey("hitbox");
            PlayerPrefs.SetInt("hitbox", 1);
        }
        
    }
    public void Plats()
    {
        if (PlayerPrefs.GetInt("plats", 1) == 0 && PlayerPrefs.GetInt("num_coins", 0) >= 2)
        {
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) - 2);
            PlayerPrefs.SetInt("plats", 1);
        }
        
    }
    public void Goal()
    {
        if (PlayerPrefs.GetInt("goal", 1) == 0 && PlayerPrefs.GetInt("num_coins", 0) >= 5)
        {
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) - 5);
            PlayerPrefs.SetInt("goal", 1);
        }
        
    }

    public void Run()
    {
        if (PlayerPrefs.GetInt("run", 1) == 0 && PlayerPrefs.GetInt("num_coins", 0) >= 1)
        {
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) - 1);
            PlayerPrefs.DeleteKey("run");
            PlayerPrefs.SetInt("run", 1);
        }
    }
    
    public void Jump()
    {
        if (PlayerPrefs.GetInt("jump", 1) == 0 && PlayerPrefs.GetInt("num_coins", 0) >= 1)
        {
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) - 1);
            PlayerPrefs.DeleteKey("jump");
            PlayerPrefs.SetInt("jump", 1);
        }
        
    }
    public void Sound()
    {
        if (PlayerPrefs.GetInt("sound", 1) == 0 && PlayerPrefs.GetInt("num_coins", 0) >= 5)
        {
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) - 5);
            PlayerPrefs.DeleteKey("sound");
            PlayerPrefs.SetInt("sound", 1);
        }

    }
    public void Fly()
    {
        if (PlayerPrefs.GetInt("fly", 1) == 0 && PlayerPrefs.GetInt("num_coins", 0) >= 5)
        {
            PlayerPrefs.SetInt("num_coins", PlayerPrefs.GetInt("num_coins", 0) - 5);
            PlayerPrefs.DeleteKey("fly");
            PlayerPrefs.SetInt("fly", 1);
        }

    }
}

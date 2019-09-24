using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("map", 0);
        PlayerPrefs.SetInt("hitbox", 0);
        PlayerPrefs.SetInt("plats", 0);
        PlayerPrefs.SetInt("goal", 0);
        PlayerPrefs.SetInt("jump", 0);
        PlayerPrefs.SetInt("player", 0);
        PlayerPrefs.SetInt("run", 0);
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Player()
    {
        PlayerPrefs.DeleteKey("player");
        PlayerPrefs.SetInt("player", 1);
    }
    public void Map()
    {
        PlayerPrefs.DeleteKey("map");
        PlayerPrefs.SetInt("map", 1);
    }
    public void Hitbox()
    {
        PlayerPrefs.DeleteKey("hitbox");
        PlayerPrefs.SetInt("hitbox", 1);
    }
    public void Plats()
    {
        PlayerPrefs.SetInt("plats", 1);
    }
    public void Goal()
    {
        PlayerPrefs.SetInt("goal", 1);
    }

    public void Run()
    {
        PlayerPrefs.DeleteKey("run");
        PlayerPrefs.SetInt("run", 1);
    }
    
    public void Jump()
    {
        PlayerPrefs.DeleteKey("jump");
        PlayerPrefs.SetInt("jump", 1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_code : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("map", 0);
        PlayerPrefs.SetInt("hitbox", 0);
        PlayerPrefs.SetInt("plats", 0);
        PlayerPrefs.SetInt("goal", 0);
        PlayerPrefs.SetInt("jump", 0);
        PlayerPrefs.SetInt("player", 0);
        PlayerPrefs.SetInt("run", 0);
        PlayerPrefs.SetInt("num_coins", 0);
        PlayerPrefs.SetInt("sound", 0);
        PlayerPrefs.SetInt("fly", 0);
        PlayerPrefs.SetInt("Coin", 0);
        PlayerPrefs.SetInt("Coin (1)", 0);
        PlayerPrefs.SetInt("Coin (2)", 0);
        PlayerPrefs.SetInt("Coin (3)", 0);
        PlayerPrefs.SetInt("Coin (4)", 0);
        PlayerPrefs.SetInt("Coin (5)", 0);
        PlayerPrefs.SetInt("Coin (6)", 0);
        PlayerPrefs.SetInt("Coin (7)", 0);
        PlayerPrefs.SetInt("Coin (8)", 0);
        PlayerPrefs.SetInt("Coin (9)", 0);
        PlayerPrefs.SetInt("Coin (10)", 0);
        PlayerPrefs.SetInt("Coin (11)", 0);
        PlayerPrefs.SetInt("Coin (12)", 0);
        PlayerPrefs.SetInt("Coin (13)", 0);
        PlayerPrefs.SetInt("Coin (14)", 0);
        PlayerPrefs.SetInt("Coin (15)", 0);
        PlayerPrefs.SetInt("Coin (16)", 0);
        PlayerPrefs.SetInt("Coin (17)", 0);
        PlayerPrefs.SetInt("Coin (18)", 0);
        PlayerPrefs.SetInt("Coin (19)", 0);
        PlayerPrefs.SetInt("Coin (20)", 0);
        PlayerPrefs.SetInt("Coin (21)", 0);
        PlayerPrefs.SetInt("Coin (22)", 0);
        PlayerPrefs.SetInt("Coin (23)", 0);
        PlayerPrefs.SetInt("Coin (24)", 0);
        PlayerPrefs.SetInt("Coin (25)", 0);
        PlayerPrefs.SetInt("Coin (26)", 0);
        PlayerPrefs.SetInt("Coin (27)", 0);
        PlayerPrefs.SetInt("Coin (28)", 0);
        PlayerPrefs.SetInt("Coin (29)", 0);
        PlayerPrefs.SetInt("Coin (30)", 0);
        PlayerPrefs.SetInt("Coin (31)", 0);
        PlayerPrefs.SetInt("Coin (32)", 0);
        PlayerPrefs.SetInt("Coin (33)", 0);
        PlayerPrefs.SetInt("Coin (34)", 0);
        PlayerPrefs.SetInt("Coin (35)", 0);
        PlayerPrefs.SetInt("Coin (36)", 0);
        PlayerPrefs.SetInt("Coin (37)", 0);
        PlayerPrefs.SetInt("Coin (38)", 0);
        PlayerPrefs.SetInt("Coin (39)", 0);
        PlayerPrefs.SetInt("Coin (40)", 0);
        PlayerPrefs.SetInt("Coin (41)", 0);
        PlayerPrefs.SetInt("Coin (42)", 0);
        PlayerPrefs.SetInt("Coin (43)", 0);
        PlayerPrefs.SetInt("Coin (44)", 0);
        PlayerPrefs.SetInt("Coin (45)", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

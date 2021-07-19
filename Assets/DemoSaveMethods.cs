using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoSaveMethods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SetPlayerData();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetPlayerData();
        }

    }
    void SetPlayerData()
    {
        PlayerPrefs.SetString("Name", "Joe");
        print("Saved te player name");
        PlayerPrefs.SetInt("Score",100);
        print("Saved te player score");
        PlayerPrefs.SetFloat("Time", 5.9f);
       
    }
    void GetPlayerData()
    {
        string name = PlayerPrefs.GetString("Name");
        print("The Player Score is: " + name);
        int score= PlayerPrefs.GetInt("Score");
        print("The Player Score is: " + score);
        float time = PlayerPrefs.GetFloat("Time");
        print("The Player Score is: " + time);

    }
}

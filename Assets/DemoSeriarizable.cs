using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class DemoSeriarizable : MonoBehaviour
{
    string systemName = Environment.MachineName.ToString();
    
  
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
        
    }
    void SetPlayerData()
    {
        string filePath = Application.persistentDataPath + "/PlayerInfo.file";
        // StreamWriter sw = new StreamWriter(filePath);
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
        BinaryWriter sw = new BinaryWriter(fs);
        sw.Write(systemName);
        fs.Close();
        sw.Close();
    
    }
    void GetPlayerData()
    {
        string filePath = Application.persistentDataPath + "/PlayerInfo.file";
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
        BinaryReader sw = new BinaryReader(fs);
        sw.ReadString();
       // ResolutionHeight = ((float)sw.ReadDouble());
        //Ram = ((float)sw.ReadDouble());
        Debug.Log("SystemName" + systemName);
       // Debug.Log("age" + Resolution);
        fs.Close();
        sw.Close();
    }
}

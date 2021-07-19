using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json.Linq;

public class JSONDemo : MonoBehaviour
{
    public string name;
    public int age;
    public string[] friends;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SavePlayerData();

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetPlayerData();
        }
    }

    public void SavePlayerData()
    {
        string filepath = Application.persistentDataPath + "/JsonDemo.sav";
        JObject jobj = new JObject();
        jobj.Add("componentName", this.name);

        JObject jdataDemo = new JObject();
        jdataDemo.Add("data",jdataDemo);
        jdataDemo.Add("_name","abcd");
        jdataDemo.Add("_curHp", this.age);

       JArray jarraydata = JArray.FromObject(friends);
       jdataDemo.Add("_friends", jarraydata);

        StreamWriter sw = new StreamWriter(filepath);
        sw.WriteLine(jobj.ToString());
        sw.Close();
    }
    public void GetPlayerData()
    {
        string filepath = Application.persistentDataPath + "/JsonDemo.sav";
        print(filepath);
        StreamReader sr = new StreamReader(filepath);
        string data = sr.ReadToEnd();
        sr.Close();
        print(data);
        JObject dataDemo = JObject.Parse(data);
        name=dataDemo["componentName"].Value<string>();
        age=dataDemo["data"]["_curHp"].Value<int>();
        friends=dataDemo["data"]["_friends"].ToObject<string[]>();
        
    }
}

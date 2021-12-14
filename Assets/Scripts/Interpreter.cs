using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class Interpreter : MonoBehaviour
{
    Dictionary<string, string> colors = new Dictionary<string, string>()
    {
        {"green", "#008000"},
        {"red", "#FF0000"}
    };
    
    bool vpn = false;
    float pcpower;

    string ip = "176.96.154.32 Reutte";
    string cpu ="CPU: Intel® Pentium® III @ 400 MHz";
    string mem ="Memory: 32MB DDR-200";
    string mobo ="Motherboard: ASUS TUSL2-C rev. 1.04 Socket 370 Motherboard";
    string gpu ="GPU: Nvidia Riva TNT";
    string hdd ="HDD: 8.4GB";

    
    List<string> response = new List<string>();
    public List<string> Interpret(string userInput)
    {
        response.Clear();

        string[] args = userInput.Split();

        //Return info about the command
        if (args[0] == "help")
        {
            response.Add("Help");
            response.Add("IPCONFIG");
            response.Add("VPN");
            response.Add("PAUSE");
            response.Add("SYSTEMINFO");
            return response;
        }
        if (args[0] == "test")
        {
            ListEntry("test", "yeees");
            ListEntry("stop", "yes");
            return response;
        }
        if (args[0] == "pause")
        {
            response.Add("Pausing...");
            PauseMenu.Paused = true;
            return response;
        }
        if (args[0] == "ascii")
        {
            LoadTitle("ascii.txt", "red", 2);
            return response;
        }
        if (args[0] == "sysinfo" || args[0] == "systeminfo")
        {
            response.Add(cpu);
            response.Add(mem);
            response.Add(mobo);
            response.Add(gpu);
            response.Add(hdd);
            response.Add("IPv4: " + ip);
            return response;
        }
        if (args[0] == "ipconfig")
        {
            response.Add("IPv4: " + ip);
            return response;
        }
        if (args[0] == "hackerradio")
        {
            FindObjectOfType<AudioManager>().Play("ya");
            response.Add("Now playing: ya.wav - Arlet Ritson");
            return response;
        }
        if (args[0] == "vpn")
        {
            if (vpn == false)
            {
                response.Add("Vpn Connected");
                ip = "216.58.210.131 Helsinki";
                Debug.Log(ip);
                vpn = true;
                Debug.Log(vpn);
            }
            else if (vpn == true)
            {
                response.Add("Vpn Offline");
                ip = "176.96.154.32 Reutte";
                vpn = false;
                Debug.Log(vpn);
            }
            return response;
        }
        else
        {
            response.Add("Komentoa ei tunnistettu, kokeile komentoa HELP");
            return response;
        }
    }

    public string ColorString(string s, string color)
    {
        string leftTag = "<color=" + color + ">";
        string rightTag = "</color>";
        return leftTag + s + rightTag;
    }

    void ListEntry(string a, string b)
    {
        response.Add(ColorString(a, colors["green"]) + ": " + ColorString(b, colors["red"]));
    }
    
    void LoadTitle(string path, string color, int spacing)
    {
        StreamReader file = new StreamReader(Path.Combine(Application.streamingAssetsPath, path));

        for(int i = 0; i < spacing; i++ )
        {
            response.Add("");
        }

        while(!file.EndOfStream)
        {
            response.Add(ColorString(file.ReadLine(), colors[color]));
        }

        for(int i = 0; i < spacing; i++ )
        {
            response.Add("");
        }

        file.Close();

    }
}
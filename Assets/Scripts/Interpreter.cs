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
    public Text DirectoryText;
    public Text DirectoryText2;

    bool vpn = false;
    bool bruteforce = false;
    bool bruteforced = false;
    bool g = true;
    bool c = false;
    bool password = false;
    bool hacked = false;

    float performance = 920f;
    int balance = 500;

    int missionID = 1;

    string ip = "176.96.154.32 Reutte";
    string cpu ="CPU: Intel® Pentium® III @ 400 MHz";
    string mem ="Memory: 32MB DDR-200";
    string mobo ="Motherboard: ASUS TUSL2-C rev. 1.04 Socket 370 Motherboard";
    string gpu ="GPU: Nvidia Riva TNT";
    string hdd ="HDD: 8.4GB";

    string targetName = "Harry E. Morris";
    string targetPhone = "580-626-5675";
    string targetAge = "19 Years Old";
    string targetEmail = "HarryEMorris@jourrapide.com";
    string targetIP = "182.34.142.241.25";

    string currentMission = "You are currently in mission 2";
    
    List<string> response = new List<string>();
    public List<string> Interpret(string userInput)
    {
        response.Clear();

        string[] args = userInput.Split();

        //Return info about the command
        if (missionID > 2)
        {
            {
                if (args[0] == "help")
                {
                    ListEntry("PCUpgrade - Cost $500", "Upgrade your pc to get more performance units");
                    ListEntry("Help", "Get help");
                    ListEntry("Mission", "Shows your current job to do");
                    ListEntry("Ipconfig", "Shows your public IP address");
                    ListEntry("VPN", "Turn on vpn to switch your IP address");
                    ListEntry("Pause", "Opens incredible pausemenu");
                    ListEntry("systeminfo", "Shows some ferocious information of your pc and network");
                    ListEntry("Hackerradio", "Plays incredible beats");
                    ListEntry("Hacker", "Surprise");
                    ListEntry("Ping", "yes");
                    ListEntry("C:", "C Drive");
                    ListEntry("G:", "G Drive");
                    ListEntry("BruteForce", "Force to crack someones password");
                    ListEntry("Tools", "Ask for recommended tools for current mission");
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
                if (args[0] == "hacker")
                {
                    LoadTitle("ascii.txt", "red", 2);
                    return response;
                }
                if (args[0] == "ping")
                {
                    response.Add("Pinging...");
                    return response;
                }
                if (args[0] == "Clear")
                {

                }
            }
            if (args[0] == "vpn")
            {
                if (vpn == false)
                {
                    response.Add("Vpn Connected");
                    ip = "216.58.210.131.85 Helsinki";
                    Debug.Log(ip);
                    vpn = true;
                    Debug.Log(vpn);
                    return response;
                }
                else if (vpn == true)
                {
                    response.Add("Vpn Offline");
                    ip = "176.96.154.32.215 Reutte";
                    vpn = false;
                    Debug.Log(vpn);
                    return response;
                }
            }
            if (args[0] == "bal" || args[0] == "balance")
            {
                response.Add("$" + balance);
                return response;
            }
            if (args[0] == "G:")
            {
                SwitchToG();
            }
            if (args[0] == "C:")
            {
                SwitchToC();
            }
            if (args[0] == "sysinfo" || args[0] == "systeminfo")
            {
                response.Add("Performance of your pc: " + performance + " units");
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
            if (args[0] == "bruteforce")
            {
                if (bruteforce == true && bruteforced == false)
                {
                        if (performance > 1000)
                        {
                            response.Add("Bruteforcing...");
                            response.Add("Trying password (8492/39330): michelle25");
                            response.Add("Found matching password for \"Admin\": michelle25");
                            bruteforced = true;
                            password = true;
                            return response;
                        }
                        else
                        {
                            response.Add("PC Exploding...");
                            return response;
                        }
                }
                else
                {
                    response.Add("You may not bruteforce anyone right now.");
                    return response;
                }
            }
            if (args[0] == "michelle25")
            {
                if (password == true)
                {
                    response.Add("You successfully entered the database.");
                    ListEntry("Boss", "Hello mr hacker man.");
                    ListEntry("Boss", "Good job you got successfully inside the database!");
                    response.Add("To get details of player you may need an email address.");
                    return response;
                }
            }
            if (args[0] == "HarryEMorris@jourrapide.com")
            {
                if (hacked == true)
                {
                    response.Add("Target information:");
                    response.Add("Age: " + targetAge);
                    response.Add("Email: " + targetEmail);
                    response.Add("IPv4: " + targetIP);
                    response.Add("Full name: " + targetName);
                    response.Add("Phone Number: " + targetPhone);
                    ListEntry("Boss", "Hello mr hacker man.");
                    ListEntry("Boss", "Now you got all the needed information of my target.");
                    ListEntry("Boss", "Use the new commands to get the modder to taste his own medicine!.");
                    response.Add("New unlocked commands:");
                    response.Add("DDOS");
                    response.Add("TextBOMBER");
                    response.Add("SendTrojan");
                    return response;
                }
            }
            if (args[0] == "hackerradio")
            {
                FindObjectOfType<AudioManager>().Play("ya");
                response.Add("Now playing: ya.wav - Arlet Ritson");
                return response;
            }
            if (args[0] == "mission")
            {
                if (missionID == 3)
                {
                    response.Add(currentMission);
                    ListEntry("Boss", "Hello mr hacker man.");
                    ListEntry("Boss", "I was just playing GTA V.");
                    ListEntry("Boss", "A modder put me in cage and now I am fuming.");
                    ListEntry("Boss", "You must stop him!");
                    ListEntry("Boss", "To see the information that I have gathered of the target, use \"TARGETINFO\"");
                    ListEntry("Boss", "Use command \"TOOLS\", to see recommended tools for current mission");
                    return response;
                }
            }
        }
        if (args[0] == "pcupgrade")
        {
            if (balance > 499)
            { 
            balance = 0;
            performance = 2255f;
            response.Add("PC Upgraded");
            response.Add("Your current pc performance: " + performance);
            response.Add("Your current balance $" + balance);
            }
            else
            {
                response.Add("You do not have enough money to upgrade your pc!");
            }

            return response;
        }
        if (args[0] == "tools")
        {
            if (missionID == 3)
            {
                response.Add("Tools - Shows available commands for current mission");
                response.Add("VPN - Turn on/off Virtual Private Network");
                response.Add("Targetinfo - Shows information of the target.");
                response.Add("EnterDatabase - Enter GTA V database");
                response.Add("PCUpgrade - Upgrade your pc to get more performance units, Cost 500");
                response.Add("BruteForce - Force to crack target's password");
                return response;
            }
            else
            {
                response.Add("You may not use this command right now.");
                return response;
            }
        }
        if (args[0] == "enterdatabase")
        {
            if (missionID == 3)
            {
                if (vpn == false)
                {
                    response.Add("Entering database...");
                    ListEntry("Boss", "I think something went wrong!");
                    ListEntry("Boss", "You have 50 seconds time to finish the job before FBI arrives");
                    bruteforce = true;
                } else if (vpn == true)
                {
                    response.Add("Entering the database...");
                    response.Add("You need to crack the admin password in order to acces the database!");
                    response.Add("Use this command again when you got password for admin");
                    bruteforce = true;
                }
                return response;
            }
            else
            {
                response.Add("You may not use this command right now.");
                return response;
            }
        }
        if (args[0] == "targetinfo")
        {
            if (missionID == 3)
            {
                //response.Add("Age: " + targetAge);
                response.Add("Email: " + targetEmail);
                //response.Add("IPv4: " + targetIP);
                //response.Add("Full name: " + targetName);
                //response.Add("Phone Number: " + targetPhone);
                return response;
            }
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
            if (missionID == 1)
            {
                ListEntry("Boss", "Welcome to Incredible Hacking Game!");
                ListEntry("Boss", "In order to start your journey use command \"HELP\" or \"MISSION\"");
                missionID = 3;
                Debug.Log(missionID);
            } else
            {
                response.Add("Command not recognized try command HELP");
            }
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
    public void SwitchToC()
    {
        this.DirectoryText.text = "C:/ System32";
        c = true;
        g = false;
    }
    public void SwitchToG()
    {
        this.DirectoryText.text = "G:/ System32";
        this.DirectoryText2.text = "G:/ System32";
        c = false;
        g = true;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class Interpreter : MonoBehaviour
{
    Dictionary<string, string> colors = new Dictionary<string, string>()
    {
        {"green", "#149414"},
        {"red", "#FF0000"},
        {"orange", "B48E00"},
        {"yellow", "FFFF00"}
    };
    public Text DirectoryText;
    public Text DirectoryText2;

    bool vpn = false;
    bool canbruteforce = false;
    bool bruteforced = false;
    bool g = true;
    bool c = false;
    bool password = false;
    bool canddos = false;
    bool indatabase = false;

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

    string currentMission = "You are currently in mission 1";
    
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
                    cost("PCUPGRADE ", "Upgrades your pc to -", " Cost: $500");
                    help("BRUTEFORCE", "Force to crack password. - <color=#FF0000>Requires 1500 performance units </color>");
                    help("HELP", "Gives you a list of all available commands");
                    help("MISSION", "Gives you an assignment");
                    help("IPCONFIG", "Shows your public IP address");
                    help("VPN", "Turn on/off Virtual Private Network");
                    help("PAUSE", "Opens incredible pausemenu. You can also use ESC to open it up.");
                    help("SYSTEMINFO", "Shows some ferocious information of your pc and network");
                    help("HACKERRADIO", "Plays incredible hack beat");
                    help("Hacker", "Surprise");
                    help("PING", "Ping your target");
                    help("TOOLS", "List of recommended tools for the current mission");
                    //help("C:", "C Drive");
                    //help("G:", "G Drive");
                    return response;
                }
                if (args[0] == "test")
                {
                    return response;
                }
                if (args[0] == "ddos")
                {
                    if (canddos == true)
                    {

                    }else
                    {
                        response.Add("You  only use DDoS when you have targets IP address.");
                    }
                    return response;
                }
                if (args[0] == "pause")
                {
                    response.Add("Opening pausemenu...");
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
                response.Add("Performance of your pc: " + performance);
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
                if (canbruteforce == true && bruteforced == false)
                {
                        if (performance > 1000)
                        {
                            response.Add("Bruteforcing...");
                            response.Add("Trying password (8492/39330): michelle25");
                            response.Add("Found matching password for \"Admin\": michelle25");
                            boss("Boss: ", "Congratulations, you got the password.");
                            notification("Try entering the database again and keep this password in mind!");
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
                    response.Add("You can only use bruteforce tool when trying to enter certain databases");
                    return response;
                }
            }
            if (args[0] == "michelle25")
            {
                if (password == true)
                {
                    response.Add("You successfully entered the database.");
                    boss("Boss", "Hello mr hacker man.");
                    boss("Boss", "Good job, you successfully made it inside the database!");
                    boss("Boss", "Now we just need an email address.");
                    indatabase = true;
                    return response;
                }
            }
            if (args[0] == "HarryEMorris@jourrapide.com")
            {
                if (indatabase == true)
                {
                    response.Add("Target information:");
                    response.Add("Age: " + targetAge);
                    response.Add("Email: " + targetEmail);
                    response.Add("IPv4: " + targetIP);
                    response.Add("Full name: " + targetName);
                    response.Add("Phone Number: " + targetPhone);
                    boss("Boss", "Hello mr hacker man.");
                    boss("Boss", "Now you got all the needed information of my target.");
                    boss("Boss", "Use the new commands to get the modder to taste his own medicine!.");
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
                    boss("Boss", "Hello mr hacker man.");
                    boss("Boss", "I was just playing Grand Theft Car V.");
                    boss("Boss", "A modder put me in cage and now I am fuming.");
                    boss("Boss", "You must stop him!");
                    boss("Boss", "Use command \"TOOLS\", to see recommended tools for current mission");
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
            response.Add("Your current performance points: " + performance);
            response.Add("Your current balance = $" + balance);
            }
            else if (performance > 2000) 
            {
                response.Add("You have already upgraded your PC!");
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
                response.Add("TARGETINFO - Shows information of the target.");
                response.Add("VPN - Turn on/off Virtual Private Network");
                response.Add("ENTERDATABASE - Enter Rickstars database");
                response.Add("BRUTEFORCE - Force to crack password");
                response.Add("PCUPGRADE - Upgrade your pc to get more performance points, Cost 500");
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
                    if (password == true)
                    {
                        response.Add("Password required");
                    }
                    boss("Boss", "I think something went wrong!");
                    boss("Boss", "You have 50 seconds time to finish the job before FBI arrives");
                    canbruteforce = true;
                } else if (vpn == true)
                {
                    response.Add("Entering the database...");
                    canbruteforce = true;
                    if (bruteforced == false)
                    {
                    boss("Boss", "You need to crack the admin password in order to acces the database!");
                    }
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
                response.Add("Email: " + targetEmail);
                boss("Boss", "You will need this e-mail address when accessing the database.");
                //response.Add("Age: " + targetAge);
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
                boss("Boss", "Welcome to Incredible Hacking Game!");
                boss("Boss", "In order to start your hacking journey use commands \"HELP\" or \"MISSION\" to get");
                notification("more infomation.");
                missionID = 3;
                Debug.Log(missionID);
            } else
            {
                response.Add("Command not recognized try command \"HELP\"");
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

    void boss(string a, string b)
    {
        response.Add(ColorString(a, colors["red"]) + ": " + ColorString(b, colors["green"]));
    }
    void help(string d, string e)
    {
        response.Add(ColorString(d, colors["green"]) + ": " + ColorString(e, colors["orange"]));
    }
    void notification(string c)
    {
        response.Add(ColorString(c, colors["green"]));
    }
        void notification2(string w)
    {
        response.Add(ColorString(w, colors["red"]));
    }
    void cost(string f, string g, string h)
    {
        response.Add(ColorString(f, colors["green"]) + ": " + ColorString(g, colors["orange"]) + ColorString(h, colors["red"]));
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
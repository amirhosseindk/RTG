using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTG.Infrastructure.Library
{
    public static class CheatConfig : Object
    {
        static CheatConfig()
        {

        }

        public static string[] settings = {"[Glow]\nGlow=1\nEnemy Only = 0\nHealth Glow = 0\nDefuse Glow = 1\nNade Glow = 1\nWeapon Glow = 1\n" ,
                    "[Counter-Terrorist]\nRed=0\nGreen=255\nBlue=0\nAlpha=255\n" ,
                    "[Terrorist]\nRed=0\nGreen=255\nBlue=0\nAlpha=255\n" ,
                    "[Defuser]\nRed=255\nGreen=0\nBlue=255\nAlpha=255\n" ,
                    "[Weapon]\nRed=75\nGreen=0\nBlue=0\nAlpha=255\n" ,
                    "[HE Grenade]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n" ,
                    "[Thrown HE Grenade]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n" ,
                    "[Flashbang]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n" ,
                    "[Thrown Flashbang]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n" ,
                    "[Smoke Grenade]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n" ,
                    "[Thrown Smoke Grenade]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n" ,
                    "[Decoy]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n" ,
                    "[Thrown Decoy]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n" ,
                    "[Molotov]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n" ,
                    "[Thrown Molotov]\nRed=150\nGreen=150\nBlue=150\nAlpha=255\n"
            };

        public static void RunCheat()
        {
            string path = null;
            path = path.getPath("Temp", "Cheat1.exe");
            File.WriteAllBytes(path, RTG.Properties.Resources.Cheat);
            ProcessStartInfo info = new ProcessStartInfo(path);
            info.UseShellExecute = true;
            info.Verb = "runas";
            Process.Start(info);
        }

        public static void SaveSC()
        {
            string txt = "321";
            File.WriteAllText(@"C:\log.txt", txt);
        }


        public static void CloseCheat()
        {
            KillCmd("Cheat1");
        }

        public static void KillCmd(string exe = "cmd")
        {
            Process[] pros;
            pros = Process.GetProcesses();
            for (int i = 0; i < pros.Length; i++)
            {
                if (pros[i].ProcessName == exe)
                {
                    pros[i].Kill();
                }
            }
        }


        public static void SaveSettings(string[] settings)
        {
            string loc = null;
            loc = loc.getPath("", "settings.cfg");
            File.WriteAllText(loc, settings[0]);
            for (int i = 1; i <= 14; i++)
            {
                File.AppendAllText(loc, settings[i]);
            }
        }

        public static bool ExistSettings()
        {

            string loc = null;
            loc = loc.getPath("", "settings.cfg");
            if (File.Exists(loc))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string getPath(this String obj, string ent, string yourfile)
        {
            switch (ent)
            {
                case ("Temp"):
                    {
                        string path = Path.Combine(Path.GetTempPath(), yourfile);
                        return path;
                    }
                default:
                    {
                        string path = Path.Combine(Directory.GetCurrentDirectory(), yourfile);
                        return path;
                    }
            }

        }

    }
}

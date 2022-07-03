using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTG.Infrastructure.Library
{
    public static class ConfigEdit
    {
        static ConfigEdit()
        {

        }

        public static void ChangeSettings(string ent, byte r, byte g, byte b, bool on)
        {
            Byte Alpha;
            if (on != true)
            {
                Alpha = 0;
            }
            else
            {
                Alpha = 255;
            }
            switch (ent)
            {
                case ("Counter-Terrorist"):
                    {
                        CheatConfig.settings[1] = "[Counter-Terrorist]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[1] = string.Format(CheatConfig.settings[1], r, g, b, Alpha);
                        CheatConfig.SaveSettings(CheatConfig.settings);
                        break;
                    }
                case ("Terrorist"):
                    {
                        CheatConfig.settings[2] = "[Terrorist]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[2] = string.Format(CheatConfig.settings[2], r, g, b, Alpha);
                        CheatConfig.SaveSettings(CheatConfig.settings);
                        break;
                    }
                case ("Molotov"):
                    {
                        CheatConfig.settings[13] = "[Molotov]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[13] = string.Format(CheatConfig.settings[13], r, g, b, Alpha);
                        CheatConfig.settings[14] = "[Thrown Molotov]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[14] = string.Format(CheatConfig.settings[14], r, g, b, Alpha);
                        CheatConfig.SaveSettings(CheatConfig.settings);
                        break;
                    }
                case ("Decoy"):
                    {
                        CheatConfig.settings[11] = "[Decoy]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[11] = string.Format(CheatConfig.settings[11], r, g, b, Alpha);
                        CheatConfig.settings[12] = "[Thrown Decoy]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[12] = string.Format(CheatConfig.settings[12], r, g, b, Alpha);
                        CheatConfig.SaveSettings(CheatConfig.settings);
                        break;
                    }
                case ("Grenade"):
                    {
                        CheatConfig.settings[5] = "[HE Grenade]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[5] = string.Format(CheatConfig.settings[5], r, g, b, Alpha);
                        CheatConfig.settings[6] = "[Thrown HE Grenade]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[6] = string.Format(CheatConfig.settings[6], r, g, b, Alpha);
                        CheatConfig.SaveSettings(CheatConfig.settings);
                        break;
                    }
                case ("Flashbang"):
                    {
                        CheatConfig.settings[7] = "[Flashbang]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[7] = string.Format(CheatConfig.settings[7], r, g, b, Alpha);
                        CheatConfig.settings[8] = "[Thrown Flashbang]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[8] = string.Format(CheatConfig.settings[8], r, g, b, Alpha);
                        CheatConfig.SaveSettings(CheatConfig.settings);
                        break;
                    }
                case ("Smoke"):
                    {
                        CheatConfig.settings[9] = "[Smoke Grenade]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[9] = string.Format(CheatConfig.settings[9], r, g, b, Alpha);
                        CheatConfig.settings[10] = "[Thrown Smoke Grenade]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[10] = string.Format(CheatConfig.settings[10], r, g, b, Alpha);
                        CheatConfig.SaveSettings(CheatConfig.settings);
                        break;
                    }
                case ("Weapon"):
                    {
                        CheatConfig.settings[4] = "[Defuser]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[4] = string.Format(CheatConfig.settings[4], r, g, b, Alpha);
                        CheatConfig.SaveSettings(CheatConfig.settings);
                        break;
                    }
                case ("Defuser"):
                    {
                        CheatConfig.settings[3] = "[Defuser]\nRed={0}\nGreen={1}\nBlue={2}\nAlpha={3}\n";
                        CheatConfig.settings[3] = string.Format(CheatConfig.settings[3], r, g, b, Alpha);
                        CheatConfig.SaveSettings(CheatConfig.settings);
                        break;
                    }
            }

        }

        public static Byte[] LoadSettings(string ent)
        {
            string loc = null;
            loc = loc.getPath("", "settings.cfg");
            switch (ent)
            {
                case ("Counter-Terrorist"):
                    {
                        string[] ct = { GetLine(loc, 9), GetLine(loc, 10), GetLine(loc, 11), GetLine(loc, 12) };
                        ct[0] = ct[0].Replace("Red=", "");
                        ct[1] = ct[1].Replace("Green=", "");
                        ct[2] = ct[2].Replace("Blue=", "");
                        ct[3] = ct[3].Replace("Alpha=", "");
                        byte[] res = { Convert.ToByte(ct[0]), Convert.ToByte(ct[1]), Convert.ToByte(ct[2]), Convert.ToByte(ct[3]) };
                        return res;
                    }
                case ("Terrorist"):
                    {
                        string[] ct = { GetLine(loc, 14), GetLine(loc, 15), GetLine(loc, 16), GetLine(loc, 17) };
                        ct[0] = ct[0].Replace("Red=", "");
                        ct[1] = ct[1].Replace("Green=", "");
                        ct[2] = ct[2].Replace("Blue=", "");
                        ct[3] = ct[3].Replace("Alpha=", "");
                        byte[] res = { Convert.ToByte(ct[0]), Convert.ToByte(ct[1]), Convert.ToByte(ct[2]), Convert.ToByte(ct[3]) };
                        return res;
                    }
                case ("Molotov"):
                    {
                        string[] ct = { GetLine(loc, 69), GetLine(loc, 70), GetLine(loc, 71), GetLine(loc, 72) };
                        ct[0] = ct[0].Replace("Red=", "");
                        ct[1] = ct[1].Replace("Green=", "");
                        ct[2] = ct[2].Replace("Blue=", "");
                        ct[3] = ct[3].Replace("Alpha=", "");
                        byte[] res = { Convert.ToByte(ct[0]), Convert.ToByte(ct[1]), Convert.ToByte(ct[2]), Convert.ToByte(ct[3]) };
                        return res;
                    }
                case ("Decoy"):
                    {
                        string[] ct = { GetLine(loc, 59), GetLine(loc, 60), GetLine(loc, 61), GetLine(loc, 62) };
                        ct[0] = ct[0].Replace("Red=", "");
                        ct[1] = ct[1].Replace("Green=", "");
                        ct[2] = ct[2].Replace("Blue=", "");
                        ct[3] = ct[3].Replace("Alpha=", "");
                        byte[] res = { Convert.ToByte(ct[0]), Convert.ToByte(ct[1]), Convert.ToByte(ct[2]), Convert.ToByte(ct[3]) };
                        return res;
                    }
                case ("Grenade"):
                    {
                        string[] ct = { GetLine(loc, 29), GetLine(loc, 30), GetLine(loc, 31), GetLine(loc, 32) };
                        ct[0] = ct[0].Replace("Red=", "");
                        ct[1] = ct[1].Replace("Green=", "");
                        ct[2] = ct[2].Replace("Blue=", "");
                        ct[3] = ct[3].Replace("Alpha=", "");
                        byte[] res = { Convert.ToByte(ct[0]), Convert.ToByte(ct[1]), Convert.ToByte(ct[2]), Convert.ToByte(ct[3]) };
                        return res;
                    }
                case ("Flashbang"):
                    {
                        string[] ct = { GetLine(loc, 39), GetLine(loc, 40), GetLine(loc, 41), GetLine(loc, 42) };
                        ct[0] = ct[0].Replace("Red=", "");
                        ct[1] = ct[1].Replace("Green=", "");
                        ct[2] = ct[2].Replace("Blue=", "");
                        ct[3] = ct[3].Replace("Alpha=", "");
                        byte[] res = { Convert.ToByte(ct[0]), Convert.ToByte(ct[1]), Convert.ToByte(ct[2]), Convert.ToByte(ct[3]) };
                        return res;
                    }
                case ("Smoke"):
                    {
                        string[] ct = { GetLine(loc, 49), GetLine(loc, 50), GetLine(loc, 51), GetLine(loc, 52) };
                        ct[0] = ct[0].Replace("Red=", "");
                        ct[1] = ct[1].Replace("Green=", "");
                        ct[2] = ct[2].Replace("Blue=", "");
                        ct[3] = ct[3].Replace("Alpha=", "");
                        byte[] res = { Convert.ToByte(ct[0]), Convert.ToByte(ct[1]), Convert.ToByte(ct[2]), Convert.ToByte(ct[3]) };
                        return res;
                    }
                case ("Weapon"):
                    {
                        string[] ct = { GetLine(loc, 24), GetLine(loc, 25), GetLine(loc, 26), GetLine(loc, 27) };
                        ct[0] = ct[0].Replace("Red=", "");
                        ct[1] = ct[1].Replace("Green=", "");
                        ct[2] = ct[2].Replace("Blue=", "");
                        ct[3] = ct[3].Replace("Alpha=", "");
                        byte[] res = { Convert.ToByte(ct[0]), Convert.ToByte(ct[1]), Convert.ToByte(ct[2]), Convert.ToByte(ct[3]) };
                        return res;
                    }
                case ("Defuser"):
                    {
                        string[] ct = { GetLine(loc, 19), GetLine(loc, 20), GetLine(loc, 21), GetLine(loc, 22) };
                        ct[0] = ct[0].Replace("Red=", "");
                        ct[1] = ct[1].Replace("Green=", "");
                        ct[2] = ct[2].Replace("Blue=", "");
                        ct[3] = ct[3].Replace("Alpha=", "");
                        byte[] res = { Convert.ToByte(ct[0]), Convert.ToByte(ct[1]), Convert.ToByte(ct[2]), Convert.ToByte(ct[3]) };
                        return res;
                    }
                default:
                    {
                        byte[] res = { 0, 0, 0, 0 };
                        return res;
                    }

            }
        }
        private static string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }

        public static void CreateSettings()
        {
            if (!CheatConfig.ExistSettings())
            {
                CheatConfig.SaveSettings(CheatConfig.settings);
            }
        }

    }
}

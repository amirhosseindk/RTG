using RTG.Infrastructure.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTG.Views
{
    public partial class MainForm : RTG.Infrastructure.Base.Forms.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        internal class rgba : Object
        {
            public rgba() : base()
            {

            }

            public static byte[] CounterTerrorist
            {
                get;
                set;
            }

            public static byte[] Terrorist
            {
                get;
                set;
            }

            public static byte[] Defuser
            {
                get;
                set;
            }

            public static byte[] Weapon
            {
                get;
                set;
            }

            public static byte[] Smoke
            {
                get;
                set;
            }

            public static byte[] Flashbang
            {
                get;
                set;
            }

            public static byte[] Grenade
            {
                get;
                set;
            }


            public static byte[] Decoy
            {
                get;
                set;
            }

            public static byte[] Molotov
            {
                get;
                set;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConfigEdit.CreateSettings();

            UserStatus.Text = "Username : " + Persistence.Data.DataContainer.user.Username;
            DayLeft.Text = "Days Remaining : " + Convert.ToString((Persistence.Data.DataContainer.user.Subscription.Date - Persistence.Data.DataContainer.now.Date).TotalDays);

            if ((Persistence.Data.DataContainer.user.Subscription.Date - Persistence.Data.DataContainer.now.Date).TotalDays > 1)
            {
                MessageBox.Show("Your Trial is finished", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }
            }

            try
            {
                rgba.CounterTerrorist = ConfigEdit.LoadSettings(comboBox1.Items[0].ToString());
                rgba.Terrorist = ConfigEdit.LoadSettings(comboBox1.Items[1].ToString());
                rgba.Defuser = ConfigEdit.LoadSettings(comboBox1.Items[2].ToString());
                rgba.Weapon = ConfigEdit.LoadSettings(comboBox1.Items[3].ToString());
                rgba.Grenade = ConfigEdit.LoadSettings(comboBox1.Items[4].ToString());
                rgba.Flashbang = ConfigEdit.LoadSettings(comboBox1.Items[5].ToString());
                rgba.Smoke = ConfigEdit.LoadSettings(comboBox1.Items[6].ToString());
                rgba.Decoy = ConfigEdit.LoadSettings(comboBox1.Items[7].ToString());
                rgba.Molotov = ConfigEdit.LoadSettings(comboBox1.Items[8].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void StrBtn_Click(object sender, EventArgs e)
        {
            CheatConfig.SaveSC();
            foreach (Control item in this.Controls)
            {
                item.Enabled = false;
            }
            StpBtn.Enabled = true;
            InfoLlb.Enabled = true;
            WelLbl.Enabled = true;
            CheatConfig.RunCheat();
            System.Threading.Thread.Sleep(4000);
            CheatConfig.KillCmd();
        }

        private void StpBtn_Click(object sender, EventArgs e)
        {
            CheatConfig.CloseCheat();
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
            }
            StpBtn.Enabled = false;
            InfoLlb.Enabled = true;
            WelLbl.Enabled = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Items[comboBox1.SelectedIndex].ToString())
            {
                case ("Counter-Terrorist"):
                    {
                        ColorButton.Color = Color.FromArgb(rgba.CounterTerrorist[0], rgba.CounterTerrorist[1], rgba.CounterTerrorist[2]);
                        if (rgba.CounterTerrorist[3] == 255)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        break;
                    }
                case ("Terrorist"):
                    {
                        ColorButton.Color = Color.FromArgb(rgba.Terrorist[0], rgba.Terrorist[1], rgba.Terrorist[2]);
                        if (rgba.Terrorist[3] == 255)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        break;
                    }
                case ("Molotov"):
                    {
                        ColorButton.Color = Color.FromArgb(rgba.Molotov[0], rgba.Molotov[1], rgba.Molotov[2]);
                        if (rgba.Molotov[3] == 255)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        break;
                    }
                case ("Decoy"):
                    {
                        ColorButton.Color = Color.FromArgb(rgba.Decoy[0], rgba.Decoy[1], rgba.Decoy[2]);
                        if (rgba.Decoy[3] == 255)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        break;
                    }
                case ("Grenade"):
                    {
                        ColorButton.Color = Color.FromArgb(rgba.Grenade[0], rgba.Grenade[1], rgba.Grenade[2]);
                        if (rgba.Grenade[3] == 255)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        break;
                    }
                case ("Flashbang"):
                    {
                        ColorButton.Color = Color.FromArgb(rgba.Flashbang[0], rgba.Flashbang[1], rgba.Flashbang[2]);
                        if (rgba.Flashbang[3] == 255)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        break;
                    }
                case ("Smoke"):
                    {
                        ColorButton.Color = Color.FromArgb(rgba.Smoke[0], rgba.Smoke[1], rgba.Smoke[2]);
                        if (rgba.Smoke[3] == 255)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        break;
                    }
                case ("Weapon"):
                    {
                        ColorButton.Color = Color.FromArgb(rgba.Weapon[0], rgba.Weapon[1], rgba.Weapon[2]);
                        if (rgba.Weapon[3] == 255)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        break;
                    }
                case ("Defuser"):
                    {
                        ColorButton.Color = Color.FromArgb(rgba.Defuser[0], rgba.Defuser[1], rgba.Defuser[2]);
                        if (rgba.Defuser[3] == 255)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;
                        break;
                    }
            }
        }

        private void ColorButton_ColorChanged(object sender, EventArgs e)
        {
            Color c = ColorButton.Color;

            byte R = c.R;
            byte G = c.G;
            byte B = c.B;

            switch (comboBox1.SelectedItem.ToString())
            {
                case ("Counter-Terrorist"):
                    {
                        rgba.CounterTerrorist[0] = R;
                        rgba.CounterTerrorist[1] = G;
                        rgba.CounterTerrorist[2] = B;
                        break;
                    }
                case ("Terrorist"):
                    {
                        rgba.Terrorist[0] = R;
                        rgba.Terrorist[1] = G;
                        rgba.Terrorist[2] = B;
                        break;
                    }
                case ("Molotov"):
                    {
                        rgba.Molotov[0] = R;
                        rgba.Molotov[1] = G;
                        rgba.Molotov[2] = B;
                        break;
                    }
                case ("Decoy"):
                    {
                        rgba.Decoy[0] = R;
                        rgba.Decoy[1] = G;
                        rgba.Decoy[2] = B;
                        break;
                    }
                case ("Grenade"):
                    {
                        rgba.Grenade[0] = R;
                        rgba.Grenade[1] = G;
                        rgba.Grenade[2] = B;
                        break;
                    }
                case ("Flashbang"):
                    {
                        rgba.Flashbang[0] = R;
                        rgba.Flashbang[1] = G;
                        rgba.Flashbang[2] = B;
                        break;
                    }
                case ("Smoke"):
                    {
                        rgba.Smoke[0] = R;
                        rgba.Smoke[1] = G;
                        rgba.Smoke[2] = B;
                        break;
                    }
                case ("Weapon"):
                    {
                        rgba.Weapon[0] = R;
                        rgba.Weapon[1] = G;
                        rgba.Weapon[2] = B;
                        break;
                    }
                case ("Defuser"):
                    {
                        rgba.Defuser[0] = R;
                        rgba.Defuser[1] = G;
                        rgba.Defuser[2] = B;
                        break;
                    }
            }
            ConfigEdit.ChangeSettings(comboBox1.SelectedItem.ToString(), R, G, B, checkBox1.Checked);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Byte Alpha;
            if (checkBox1.Checked != true)
            {
                Alpha = 0;
            }
            else
            {
                Alpha = 255;
            }
            ConfigEdit.ChangeSettings(comboBox1.SelectedItem.ToString(), ColorButton.Color.R, ColorButton.Color.G, ColorButton.Color.B, checkBox1.Checked);
            switch (comboBox1.SelectedItem.ToString())
            {
                case ("Counter-Terrorist"):
                    {
                        rgba.CounterTerrorist[3] = Alpha;
                        break;
                    }
                case ("Terrorist"):
                    {
                        rgba.Terrorist[3] = Alpha;
                        break;
                    }
                case ("Molotov"):
                    {
                        rgba.Molotov[3] = Alpha;
                        break;
                    }
                case ("Decoy"):
                    {
                        rgba.Decoy[3] = Alpha;
                        break;
                    }
                case ("Grenade"):
                    {
                        rgba.Grenade[3] = Alpha;
                        break;
                    }
                case ("Flashbang"):
                    {
                        rgba.Flashbang[3] = Alpha;
                        break;
                    }
                case ("Smoke"):
                    {
                        rgba.Smoke[3] = Alpha;
                        break;
                    }
                case ("Weapon"):
                    {
                        rgba.Weapon[3] = Alpha;
                        break;
                    }
                case ("Defuser"):
                    {
                        rgba.Defuser[3] = Alpha;
                        break;
                    }
            }
        }
    }
}

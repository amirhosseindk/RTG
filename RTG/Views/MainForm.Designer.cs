
namespace RTG.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StatusStrip = new ADK.Windows.MyComponents.myStatusStrip();
            this.UserStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.DayLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.InfoLlb = new ADK.Windows.MyComponents.myLable();
            this.ColorGpBox = new ADK.Windows.MyComponents.myGroupBox();
            this.ColorButton = new ADK.Windows.MyComponents.myColorButton();
            this.checkBox1 = new ADK.Windows.MyComponents.myCheckBox();
            this.comboBox1 = new ADK.Windows.MyComponents.myComboBox();
            this.WelLbl = new ADK.Windows.MyComponents.myLable();
            this.StrBtn = new ADK.Windows.MyComponents.myButton();
            this.StpBtn = new ADK.Windows.MyComponents.myButton();
            this.myPictureBox1 = new ADK.Windows.MyComponents.myPictureBox();
            this.StatusStrip.SuspendLayout();
            this.ColorGpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserStatus,
            this.DayLeft});
            this.StatusStrip.Location = new System.Drawing.Point(0, 1176);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 34, 0);
            this.StatusStrip.Size = new System.Drawing.Size(913, 54);
            this.StatusStrip.TabIndex = 13;
            this.StatusStrip.Text = "myStatusStrip1";
            // 
            // UserStatus
            // 
            this.UserStatus.BackColor = System.Drawing.Color.Transparent;
            this.UserStatus.ForeColor = System.Drawing.Color.White;
            this.UserStatus.Name = "UserStatus";
            this.UserStatus.Size = new System.Drawing.Size(158, 41);
            this.UserStatus.Text = "UserStatus";
            // 
            // DayLeft
            // 
            this.DayLeft.ForeColor = System.Drawing.Color.White;
            this.DayLeft.Name = "DayLeft";
            this.DayLeft.Size = new System.Drawing.Size(118, 41);
            this.DayLeft.Text = "DayLeft";
            // 
            // InfoLlb
            // 
            this.InfoLlb.AutoSize = true;
            this.InfoLlb.ForeColor = System.Drawing.Color.White;
            this.InfoLlb.Location = new System.Drawing.Point(433, 341);
            this.InfoLlb.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.InfoLlb.Name = "InfoLlb";
            this.InfoLlb.Size = new System.Drawing.Size(414, 41);
            this.InfoLlb.TabIndex = 12;
            this.InfoLlb.Text = "You Have Only WallHack Sub .";
            // 
            // ColorGpBox
            // 
            this.ColorGpBox.Controls.Add(this.ColorButton);
            this.ColorGpBox.Controls.Add(this.checkBox1);
            this.ColorGpBox.Controls.Add(this.comboBox1);
            this.ColorGpBox.ForeColor = System.Drawing.Color.White;
            this.ColorGpBox.Location = new System.Drawing.Point(117, 514);
            this.ColorGpBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ColorGpBox.Name = "ColorGpBox";
            this.ColorGpBox.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ColorGpBox.Size = new System.Drawing.Size(614, 350);
            this.ColorGpBox.TabIndex = 10;
            this.ColorGpBox.TabStop = false;
            this.ColorGpBox.Text = " Color ";
            // 
            // ColorButton
            // 
            this.ColorButton.EditValue = System.Drawing.Color.Empty;
            this.ColorButton.Location = new System.Drawing.Point(61, 210);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.ColorButton.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ColorButton.Size = new System.Drawing.Size(349, 48);
            this.ColorButton.TabIndex = 3;
            this.ColorButton.ColorChanged += new System.EventHandler(this.ColorButton_ColorChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(467, 210);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 45);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "ON";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Counter-Terrorist",
            "Terrorist",
            "Defuser",
            "Weapon",
            "Grenade",
            "Flashbang",
            "Smoke",
            "Decoy",
            "Molotov"});
            this.comboBox1.Location = new System.Drawing.Point(61, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(507, 49);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // WelLbl
            // 
            this.WelLbl.AutoSize = true;
            this.WelLbl.ForeColor = System.Drawing.Color.White;
            this.WelLbl.Location = new System.Drawing.Point(433, 257);
            this.WelLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.WelLbl.Name = "WelLbl";
            this.WelLbl.Size = new System.Drawing.Size(159, 41);
            this.WelLbl.TabIndex = 9;
            this.WelLbl.Text = "Welcome !";
            // 
            // StrBtn
            // 
            this.StrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StrBtn.ForeColor = System.Drawing.Color.White;
            this.StrBtn.Location = new System.Drawing.Point(117, 992);
            this.StrBtn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.StrBtn.Name = "StrBtn";
            this.StrBtn.Size = new System.Drawing.Size(231, 120);
            this.StrBtn.TabIndex = 8;
            this.StrBtn.Text = "Start";
            this.StrBtn.UseVisualStyleBackColor = false;
            this.StrBtn.Click += new System.EventHandler(this.StrBtn_Click);
            // 
            // StpBtn
            // 
            this.StpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StpBtn.Enabled = false;
            this.StpBtn.ForeColor = System.Drawing.Color.White;
            this.StpBtn.Location = new System.Drawing.Point(500, 992);
            this.StpBtn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.StpBtn.Name = "StpBtn";
            this.StpBtn.Size = new System.Drawing.Size(231, 120);
            this.StpBtn.TabIndex = 7;
            this.StpBtn.Text = "Stop";
            this.StpBtn.UseVisualStyleBackColor = false;
            this.StpBtn.Click += new System.EventHandler(this.StpBtn_Click);
            // 
            // myPictureBox1
            // 
            this.myPictureBox1.Image = global::RTG.Properties.Resources.user;
            this.myPictureBox1.Location = new System.Drawing.Point(117, 184);
            this.myPictureBox1.Name = "myPictureBox1";
            this.myPictureBox1.Size = new System.Drawing.Size(250, 227);
            this.myPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPictureBox1.TabIndex = 14;
            this.myPictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(913, 1230);
            this.Controls.Add(this.myPictureBox1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.InfoLlb);
            this.Controls.Add(this.ColorGpBox);
            this.Controls.Add(this.WelLbl);
            this.Controls.Add(this.StrBtn);
            this.Controls.Add(this.StpBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ColorGpBox.ResumeLayout(false);
            this.ColorGpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADK.Windows.MyComponents.myStatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel UserStatus;
        private System.Windows.Forms.ToolStripStatusLabel DayLeft;
        private ADK.Windows.MyComponents.myLable InfoLlb;
        private ADK.Windows.MyComponents.myGroupBox ColorGpBox;
        private ADK.Windows.MyComponents.myCheckBox checkBox1;
        private ADK.Windows.MyComponents.myComboBox comboBox1;
        private ADK.Windows.MyComponents.myLable WelLbl;
        private ADK.Windows.MyComponents.myButton StrBtn;
        private ADK.Windows.MyComponents.myButton StpBtn;
        private ADK.Windows.MyComponents.myColorButton ColorButton;
        private ADK.Windows.MyComponents.myPictureBox myPictureBox1;
    }
}
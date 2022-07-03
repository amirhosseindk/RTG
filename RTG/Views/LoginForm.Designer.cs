
namespace RTG.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginBtn = new ADK.Windows.MyComponents.myButton();
            this.PassTxt = new ADK.Windows.MyComponents.myTextBox();
            this.UserTxt = new ADK.Windows.MyComponents.myTextBox();
            this.UserLbl = new ADK.Windows.MyComponents.myLable();
            this.PassLbl = new ADK.Windows.MyComponents.myLable();
            this.PerBtn = new ADK.Windows.MyComponents.myButton();
            this.EngBtn = new ADK.Windows.MyComponents.myButton();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(388, 377);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(317, 79);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(425, 275);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(364, 47);
            this.PassTxt.TabIndex = 1;
            this.PassTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTxt_KeyPress);
            // 
            // UserTxt
            // 
            this.UserTxt.Location = new System.Drawing.Point(425, 184);
            this.UserTxt.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(364, 47);
            this.UserTxt.TabIndex = 2;
            this.UserTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserTxt_KeyPress);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserLbl.ForeColor = System.Drawing.Color.White;
            this.UserLbl.Location = new System.Drawing.Point(227, 187);
            this.UserLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(167, 41);
            this.UserLbl.TabIndex = 3;
            this.UserLbl.Text = "Username :";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.BackColor = System.Drawing.Color.Transparent;
            this.PassLbl.ForeColor = System.Drawing.Color.White;
            this.PassLbl.Location = new System.Drawing.Point(227, 278);
            this.PassLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(158, 41);
            this.PassLbl.TabIndex = 4;
            this.PassLbl.Text = "Password :";
            // 
            // PerBtn
            // 
            this.PerBtn.BackgroundImage = global::RTG.Properties.Resources.icons8_iran_48;
            this.PerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PerBtn.Location = new System.Drawing.Point(26, 32);
            this.PerBtn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.PerBtn.Name = "PerBtn";
            this.PerBtn.Size = new System.Drawing.Size(64, 64);
            this.PerBtn.TabIndex = 5;
            this.PerBtn.UseVisualStyleBackColor = true;
            // 
            // EngBtn
            // 
            this.EngBtn.BackgroundImage = global::RTG.Properties.Resources.icons8_usa_48;
            this.EngBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EngBtn.Location = new System.Drawing.Point(104, 32);
            this.EngBtn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.EngBtn.Name = "EngBtn";
            this.EngBtn.Size = new System.Drawing.Size(64, 64);
            this.EngBtn.TabIndex = 6;
            this.EngBtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RTG.Properties.Resources.BCK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 577);
            this.Controls.Add(this.EngBtn);
            this.Controls.Add(this.PerBtn);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.LoginBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADK.Windows.MyComponents.myButton LoginBtn;
        private ADK.Windows.MyComponents.myTextBox PassTxt;
        private ADK.Windows.MyComponents.myTextBox UserTxt;
        private ADK.Windows.MyComponents.myLable UserLbl;
        private ADK.Windows.MyComponents.myLable PassLbl;
        private ADK.Windows.MyComponents.myButton PerBtn;
        private ADK.Windows.MyComponents.myButton EngBtn;
    }
}
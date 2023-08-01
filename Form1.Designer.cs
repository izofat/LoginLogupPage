namespace Password_checker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxlogupusername = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textBoxloguppassword = new System.Windows.Forms.TextBox();
            this.buttonlogup = new System.Windows.Forms.Button();
            this.buttonshow = new System.Windows.Forms.Button();
            this.labelsuccess = new System.Windows.Forms.Label();
            this.labelunsuccess = new System.Windows.Forms.Label();
            this.labelunsuccess1 = new System.Windows.Forms.Label();
            this.labelloginsuccess = new System.Windows.Forms.Label();
            this.buttonshow1 = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxloginpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxloginusername = new System.Windows.Forms.TextBox();
            this.labelusernametaken = new System.Windows.Forms.Label();
            this.groupBoxlogup = new System.Windows.Forms.GroupBox();
            this.groupBoxlogin = new System.Windows.Forms.GroupBox();
            this.buttonshowlogin = new System.Windows.Forms.Button();
            this.buttonshowlogup = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxlogup.SuspendLayout();
            this.groupBoxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxlogupusername
            // 
            this.textBoxlogupusername.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxlogupusername.Location = new System.Drawing.Point(20, 52);
            this.textBoxlogupusername.Name = "textBoxlogupusername";
            this.textBoxlogupusername.Size = new System.Drawing.Size(178, 34);
            this.textBoxlogupusername.TabIndex = 0;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(15, 22);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(126, 27);
            this.labelusername.TabIndex = 1;
            this.labelusername.Text = "Username ";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(15, 135);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(121, 27);
            this.labelpassword.TabIndex = 2;
            this.labelpassword.Text = "Password ";
            // 
            // textBoxloguppassword
            // 
            this.textBoxloguppassword.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxloguppassword.Location = new System.Drawing.Point(20, 165);
            this.textBoxloguppassword.Name = "textBoxloguppassword";
            this.textBoxloguppassword.Size = new System.Drawing.Size(178, 34);
            this.textBoxloguppassword.TabIndex = 3;
            this.textBoxloguppassword.UseSystemPasswordChar = true;
            // 
            // buttonlogup
            // 
            this.buttonlogup.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogup.Location = new System.Drawing.Point(20, 294);
            this.buttonlogup.Name = "buttonlogup";
            this.buttonlogup.Size = new System.Drawing.Size(178, 54);
            this.buttonlogup.TabIndex = 4;
            this.buttonlogup.Text = "Log up";
            this.buttonlogup.UseVisualStyleBackColor = true;
            this.buttonlogup.Click += new System.EventHandler(this.buttonlogup_Click);
            // 
            // buttonshow
            // 
            this.buttonshow.Image = ((System.Drawing.Image)(resources.GetObject("buttonshow.Image")));
            this.buttonshow.Location = new System.Drawing.Point(195, 165);
            this.buttonshow.Name = "buttonshow";
            this.buttonshow.Size = new System.Drawing.Size(49, 34);
            this.buttonshow.TabIndex = 5;
            this.buttonshow.UseVisualStyleBackColor = true;
            this.buttonshow.Click += new System.EventHandler(this.buttonshow_Click);
            // 
            // labelsuccess
            // 
            this.labelsuccess.AutoSize = true;
            this.labelsuccess.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsuccess.Location = new System.Drawing.Point(3, 214);
            this.labelsuccess.Name = "labelsuccess";
            this.labelsuccess.Size = new System.Drawing.Size(20, 22);
            this.labelsuccess.TabIndex = 6;
            this.labelsuccess.Text = "0";
            this.labelsuccess.Visible = false;
            // 
            // labelunsuccess
            // 
            this.labelunsuccess.AutoSize = true;
            this.labelunsuccess.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelunsuccess.Location = new System.Drawing.Point(3, 236);
            this.labelunsuccess.Name = "labelunsuccess";
            this.labelunsuccess.Size = new System.Drawing.Size(20, 22);
            this.labelunsuccess.TabIndex = 7;
            this.labelunsuccess.Text = "0";
            this.labelunsuccess.Visible = false;
            // 
            // labelunsuccess1
            // 
            this.labelunsuccess1.AutoSize = true;
            this.labelunsuccess1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelunsuccess1.Location = new System.Drawing.Point(3, 258);
            this.labelunsuccess1.Name = "labelunsuccess1";
            this.labelunsuccess1.Size = new System.Drawing.Size(20, 22);
            this.labelunsuccess1.TabIndex = 8;
            this.labelunsuccess1.Text = "0";
            this.labelunsuccess1.Visible = false;
            // 
            // labelloginsuccess
            // 
            this.labelloginsuccess.AutoSize = true;
            this.labelloginsuccess.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloginsuccess.Location = new System.Drawing.Point(23, 210);
            this.labelloginsuccess.Name = "labelloginsuccess";
            this.labelloginsuccess.Size = new System.Drawing.Size(20, 22);
            this.labelloginsuccess.TabIndex = 15;
            this.labelloginsuccess.Text = "0";
            this.labelloginsuccess.Visible = false;
            // 
            // buttonshow1
            // 
            this.buttonshow1.Image = ((System.Drawing.Image)(resources.GetObject("buttonshow1.Image")));
            this.buttonshow1.Location = new System.Drawing.Point(202, 153);
            this.buttonshow1.Name = "buttonshow1";
            this.buttonshow1.Size = new System.Drawing.Size(49, 34);
            this.buttonshow1.TabIndex = 14;
            this.buttonshow1.UseVisualStyleBackColor = true;
            this.buttonshow1.Click += new System.EventHandler(this.buttonshow1_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.Location = new System.Drawing.Point(27, 284);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(178, 54);
            this.buttonlogin.TabIndex = 13;
            this.buttonlogin.Text = "Log in";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // textBoxloginpassword
            // 
            this.textBoxloginpassword.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxloginpassword.Location = new System.Drawing.Point(27, 153);
            this.textBoxloginpassword.Name = "textBoxloginpassword";
            this.textBoxloginpassword.Size = new System.Drawing.Size(178, 34);
            this.textBoxloginpassword.TabIndex = 12;
            this.textBoxloginpassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username ";
            // 
            // textBoxloginusername
            // 
            this.textBoxloginusername.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxloginusername.Location = new System.Drawing.Point(27, 42);
            this.textBoxloginusername.Name = "textBoxloginusername";
            this.textBoxloginusername.Size = new System.Drawing.Size(178, 34);
            this.textBoxloginusername.TabIndex = 9;
            // 
            // labelusernametaken
            // 
            this.labelusernametaken.AutoSize = true;
            this.labelusernametaken.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusernametaken.Location = new System.Drawing.Point(16, 101);
            this.labelusernametaken.Name = "labelusernametaken";
            this.labelusernametaken.Size = new System.Drawing.Size(20, 22);
            this.labelusernametaken.TabIndex = 16;
            this.labelusernametaken.Text = "0";
            this.labelusernametaken.Visible = false;
            // 
            // groupBoxlogup
            // 
            this.groupBoxlogup.Controls.Add(this.buttonlogup);
            this.groupBoxlogup.Controls.Add(this.labelusernametaken);
            this.groupBoxlogup.Controls.Add(this.textBoxlogupusername);
            this.groupBoxlogup.Controls.Add(this.labelusername);
            this.groupBoxlogup.Controls.Add(this.labelpassword);
            this.groupBoxlogup.Controls.Add(this.textBoxloguppassword);
            this.groupBoxlogup.Controls.Add(this.buttonshow);
            this.groupBoxlogup.Controls.Add(this.labelsuccess);
            this.groupBoxlogup.Controls.Add(this.labelunsuccess);
            this.groupBoxlogup.Controls.Add(this.labelunsuccess1);
            this.groupBoxlogup.Location = new System.Drawing.Point(17, 23);
            this.groupBoxlogup.Name = "groupBoxlogup";
            this.groupBoxlogup.Size = new System.Drawing.Size(401, 382);
            this.groupBoxlogup.TabIndex = 17;
            this.groupBoxlogup.TabStop = false;
            this.groupBoxlogup.Visible = false;
            // 
            // groupBoxlogin
            // 
            this.groupBoxlogin.Controls.Add(this.buttonlogin);
            this.groupBoxlogin.Controls.Add(this.textBoxloginusername);
            this.groupBoxlogin.Controls.Add(this.labelloginsuccess);
            this.groupBoxlogin.Controls.Add(this.label5);
            this.groupBoxlogin.Controls.Add(this.buttonshow1);
            this.groupBoxlogin.Controls.Add(this.label4);
            this.groupBoxlogin.Controls.Add(this.textBoxloginpassword);
            this.groupBoxlogin.Location = new System.Drawing.Point(593, 23);
            this.groupBoxlogin.Name = "groupBoxlogin";
            this.groupBoxlogin.Size = new System.Drawing.Size(369, 382);
            this.groupBoxlogin.TabIndex = 18;
            this.groupBoxlogin.TabStop = false;
            this.groupBoxlogin.Visible = false;
            // 
            // buttonshowlogin
            // 
            this.buttonshowlogin.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowlogin.Location = new System.Drawing.Point(417, 105);
            this.buttonshowlogin.Name = "buttonshowlogin";
            this.buttonshowlogin.Size = new System.Drawing.Size(178, 54);
            this.buttonshowlogin.TabIndex = 20;
            this.buttonshowlogin.Text = "Log in";
            this.buttonshowlogin.UseVisualStyleBackColor = true;
            this.buttonshowlogin.Click += new System.EventHandler(this.buttonshowlogin_Click);
            // 
            // buttonshowlogup
            // 
            this.buttonshowlogup.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowlogup.Location = new System.Drawing.Point(417, 186);
            this.buttonshowlogup.Name = "buttonshowlogup";
            this.buttonshowlogup.Size = new System.Drawing.Size(178, 54);
            this.buttonshowlogup.TabIndex = 21;
            this.buttonshowlogup.Text = "Log up";
            this.buttonshowlogup.UseVisualStyleBackColor = true;
            this.buttonshowlogup.Click += new System.EventHandler(this.buttonshowlogup_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 442);
            this.Controls.Add(this.buttonshowlogup);
            this.Controls.Add(this.buttonshowlogin);
            this.Controls.Add(this.groupBoxlogin);
            this.Controls.Add(this.groupBoxlogup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxlogup.ResumeLayout(false);
            this.groupBoxlogup.PerformLayout();
            this.groupBoxlogin.ResumeLayout(false);
            this.groupBoxlogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxlogupusername;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textBoxloguppassword;
        private System.Windows.Forms.Button buttonlogup;
        private System.Windows.Forms.Button buttonshow;
        private System.Windows.Forms.Label labelsuccess;
        private System.Windows.Forms.Label labelunsuccess;
        private System.Windows.Forms.Label labelunsuccess1;
        private System.Windows.Forms.Label labelloginsuccess;
        private System.Windows.Forms.Button buttonshow1;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxloginpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxloginusername;
        private System.Windows.Forms.Label labelusernametaken;
        private System.Windows.Forms.GroupBox groupBoxlogup;
        private System.Windows.Forms.GroupBox groupBoxlogin;
        private System.Windows.Forms.Button buttonshowlogin;
        private System.Windows.Forms.Button buttonshowlogup;
        private System.Windows.Forms.Timer timer1;
    }
}


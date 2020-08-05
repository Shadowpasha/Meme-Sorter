namespace Meme_Sorter
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.button4 = new MetroFramework.Controls.MetroButton();
            this.choose_folder = new MetroFramework.Controls.MetroButton();
            this.Choosefolder = new System.Windows.Forms.FolderBrowserDialog();
            this.sort1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.button5 = new MetroFramework.Controls.MetroButton();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button6 = new MetroFramework.Controls.MetroButton();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Main = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(17, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1112, 493);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Folder 1";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(997, 541);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Next Image";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(813, 541);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "Previous Image";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // choose_folder
            // 
            this.choose_folder.Location = new System.Drawing.Point(171, 541);
            this.choose_folder.Name = "choose_folder";
            this.choose_folder.Size = new System.Drawing.Size(150, 55);
            this.choose_folder.TabIndex = 5;
            this.choose_folder.Text = "Choose Folder";
            this.choose_folder.Click += new System.EventHandler(this.choose_folder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Folder 2";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(87, 633);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 26);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label1.Location = new System.Drawing.Point(17, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Go To :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(225, 624);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "Confirm";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.TabIndex = 10;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(17, 32);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1112, 493);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(659, 541);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 55);
            this.button6.TabIndex = 12;
            this.button6.Text = "Delete Last";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(951, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 0);
            this.label4.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Main);
            this.metroTabControl1.Location = new System.Drawing.Point(16, 27);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1177, 701);
            this.metroTabControl1.TabIndex = 18;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.label4);
            this.Main.Controls.Add(this.label3);
            this.Main.Controls.Add(this.metroButton1);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.button5);
            this.Main.Controls.Add(this.textBox2);
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Controls.Add(this.axWindowsMediaPlayer1);
            this.Main.Controls.Add(this.button6);
            this.Main.Controls.Add(this.button3);
            this.Main.Controls.Add(this.button4);
            this.Main.Controls.Add(this.button1);
            this.Main.Controls.Add(this.button2);
            this.Main.Controls.Add(this.choose_folder);
            this.Main.HorizontalScrollbarBarColor = true;
            this.Main.Location = new System.Drawing.Point(4, 35);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1169, 662);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.VerticalScrollbarBarColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(17, 541);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(132, 55);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Last Number?";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 741);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1200, 741);
            this.MinimumSize = new System.Drawing.Size(1200, 741);
            this.Name = "Form1";
            this.Text = "Meme Sorter";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton button2;
        private MetroFramework.Controls.MetroButton button3;
        private MetroFramework.Controls.MetroButton button4;
        private MetroFramework.Controls.MetroButton choose_folder;
        private System.Windows.Forms.FolderBrowserDialog Choosefolder;
        private System.Windows.Forms.FolderBrowserDialog sort1;
        private MetroFramework.Controls.MetroButton button1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroButton button5;
        private MetroFramework.Controls.MetroLabel label2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MetroFramework.Controls.MetroButton button6;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label4;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Main;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}


namespace Xenia_Canary_Shortcut_Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BrowseGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GameNameTbox = new System.Windows.Forms.TextBox();
            this.UseDediConfigCbox = new System.Windows.Forms.CheckBox();
            this.BrowseXeniaBtn = new System.Windows.Forms.Button();
            this.FullscreenCbox = new System.Windows.Forms.CheckBox();
            this.CreateShortcutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfigFilePathLbl = new System.Windows.Forms.Label();
            this.CurrentGamePathLbl = new System.Windows.Forms.Label();
            this.CurrentXeniaPathLbl = new System.Windows.Forms.Label();
            this.CreatedByLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrowseGameBtn
            // 
            this.BrowseGameBtn.Enabled = false;
            this.BrowseGameBtn.Location = new System.Drawing.Point(97, 37);
            this.BrowseGameBtn.Name = "BrowseGameBtn";
            this.BrowseGameBtn.Size = new System.Drawing.Size(198, 23);
            this.BrowseGameBtn.TabIndex = 0;
            this.BrowseGameBtn.Text = "Browse for Game xex";
            this.BrowseGameBtn.UseVisualStyleBackColor = true;
            this.BrowseGameBtn.Click += new System.EventHandler(this.BrowseGameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Xenia Path";
            // 
            // GameNameTbox
            // 
            this.GameNameTbox.Enabled = false;
            this.GameNameTbox.Location = new System.Drawing.Point(97, 66);
            this.GameNameTbox.Name = "GameNameTbox";
            this.GameNameTbox.Size = new System.Drawing.Size(198, 20);
            this.GameNameTbox.TabIndex = 2;
            this.GameNameTbox.TextChanged += new System.EventHandler(this.GameNameTbox_TextChanged);
            // 
            // UseDediConfigCbox
            // 
            this.UseDediConfigCbox.AutoSize = true;
            this.UseDediConfigCbox.Location = new System.Drawing.Point(97, 92);
            this.UseDediConfigCbox.Name = "UseDediConfigCbox";
            this.UseDediConfigCbox.Size = new System.Drawing.Size(143, 17);
            this.UseDediConfigCbox.TabIndex = 3;
            this.UseDediConfigCbox.Text = "Use dedicated config file";
            this.UseDediConfigCbox.UseVisualStyleBackColor = true;
            // 
            // BrowseXeniaBtn
            // 
            this.BrowseXeniaBtn.Location = new System.Drawing.Point(97, 8);
            this.BrowseXeniaBtn.Name = "BrowseXeniaBtn";
            this.BrowseXeniaBtn.Size = new System.Drawing.Size(198, 23);
            this.BrowseXeniaBtn.TabIndex = 4;
            this.BrowseXeniaBtn.Text = "Browse for Xenia.exe";
            this.BrowseXeniaBtn.UseVisualStyleBackColor = true;
            this.BrowseXeniaBtn.Click += new System.EventHandler(this.BrowseXeniaBtn_Click);
            // 
            // FullscreenCbox
            // 
            this.FullscreenCbox.AutoSize = true;
            this.FullscreenCbox.Location = new System.Drawing.Point(97, 115);
            this.FullscreenCbox.Name = "FullscreenCbox";
            this.FullscreenCbox.Size = new System.Drawing.Size(121, 17);
            this.FullscreenCbox.TabIndex = 5;
            this.FullscreenCbox.Text = "Launch in fullscreen";
            this.FullscreenCbox.UseVisualStyleBackColor = true;
            // 
            // CreateShortcutBtn
            // 
            this.CreateShortcutBtn.Enabled = false;
            this.CreateShortcutBtn.Location = new System.Drawing.Point(97, 138);
            this.CreateShortcutBtn.Name = "CreateShortcutBtn";
            this.CreateShortcutBtn.Size = new System.Drawing.Size(588, 45);
            this.CreateShortcutBtn.TabIndex = 6;
            this.CreateShortcutBtn.Text = "Create Shortcut";
            this.CreateShortcutBtn.UseVisualStyleBackColor = true;
            this.CreateShortcutBtn.Click += new System.EventHandler(this.CreateShortcutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Game Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Game Name";
            // 
            // ConfigFilePathLbl
            // 
            this.ConfigFilePathLbl.AutoSize = true;
            this.ConfigFilePathLbl.Location = new System.Drawing.Point(301, 93);
            this.ConfigFilePathLbl.Name = "ConfigFilePathLbl";
            this.ConfigFilePathLbl.Size = new System.Drawing.Size(0, 13);
            this.ConfigFilePathLbl.TabIndex = 11;
            // 
            // CurrentGamePathLbl
            // 
            this.CurrentGamePathLbl.AutoSize = true;
            this.CurrentGamePathLbl.Location = new System.Drawing.Point(300, 42);
            this.CurrentGamePathLbl.Name = "CurrentGamePathLbl";
            this.CurrentGamePathLbl.Size = new System.Drawing.Size(0, 13);
            this.CurrentGamePathLbl.TabIndex = 10;
            // 
            // CurrentXeniaPathLbl
            // 
            this.CurrentXeniaPathLbl.AutoSize = true;
            this.CurrentXeniaPathLbl.Location = new System.Drawing.Point(301, 13);
            this.CurrentXeniaPathLbl.Name = "CurrentXeniaPathLbl";
            this.CurrentXeniaPathLbl.Size = new System.Drawing.Size(0, 13);
            this.CurrentXeniaPathLbl.TabIndex = 9;
            // 
            // CreatedByLbl
            // 
            this.CreatedByLbl.AutoSize = true;
            this.CreatedByLbl.ForeColor = System.Drawing.Color.Red;
            this.CreatedByLbl.Location = new System.Drawing.Point(596, 194);
            this.CreatedByLbl.Name = "CreatedByLbl";
            this.CreatedByLbl.Size = new System.Drawing.Size(90, 13);
            this.CreatedByLbl.TabIndex = 12;
            this.CreatedByLbl.Text = "Created by Byrom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 216);
            this.Controls.Add(this.CreatedByLbl);
            this.Controls.Add(this.ConfigFilePathLbl);
            this.Controls.Add(this.CurrentGamePathLbl);
            this.Controls.Add(this.CurrentXeniaPathLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateShortcutBtn);
            this.Controls.Add(this.FullscreenCbox);
            this.Controls.Add(this.BrowseXeniaBtn);
            this.Controls.Add(this.UseDediConfigCbox);
            this.Controls.Add(this.GameNameTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseGameBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Xenia Canary Shortcut Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GameNameTbox;
        private System.Windows.Forms.CheckBox UseDediConfigCbox;
        private System.Windows.Forms.Button BrowseXeniaBtn;
        private System.Windows.Forms.CheckBox FullscreenCbox;
        private System.Windows.Forms.Button CreateShortcutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ConfigFilePathLbl;
        private System.Windows.Forms.Label CurrentGamePathLbl;
        private System.Windows.Forms.Label CurrentXeniaPathLbl;
        private System.Windows.Forms.Label CreatedByLbl;
    }
}


﻿namespace My_Friend
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
            this.label1 = new System.Windows.Forms.Label();
            this.System_voice = new System.Windows.Forms.Button();
            this.Command = new System.Windows.Forms.TextBox();
            this.Speak_here = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(51, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi, Friend How Can I \r\nHelp You";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // System_voice
            // 
            this.System_voice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.System_voice.ForeColor = System.Drawing.Color.Black;
            this.System_voice.Location = new System.Drawing.Point(12, 312);
            this.System_voice.Name = "System_voice";
            this.System_voice.Size = new System.Drawing.Size(83, 29);
            this.System_voice.TabIndex = 2;
            this.System_voice.Text = "System voice";
            this.System_voice.UseVisualStyleBackColor = false;
            this.System_voice.Click += new System.EventHandler(this.button1_Click);
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(12, 12);
            this.Command.Multiline = true;
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(282, 27);
            this.Command.TabIndex = 3;
            this.Command.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Speak_here
            // 
            this.Speak_here.Location = new System.Drawing.Point(101, 312);
            this.Speak_here.Name = "Speak_here";
            this.Speak_here.Size = new System.Drawing.Size(92, 29);
            this.Speak_here.TabIndex = 5;
            this.Speak_here.Text = "Speak Here";
            this.Speak_here.UseVisualStyleBackColor = true;
            this.Speak_here.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Speak_here);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.System_voice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button System_voice;
        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.Button Speak_here;
        private System.Windows.Forms.Button button2;

    }
}


namespace My_Friend
{
    partial class My_Friend
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
            this.InfoBox = new System.Windows.Forms.Label();
            this.Command = new System.Windows.Forms.TextBox();
            this.Reply = new System.Windows.Forms.TextBox();
            this.Speak_here = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Visualiser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Visualiser)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoBox
            // 
            this.InfoBox.AutoSize = true;
            this.InfoBox.BackColor = System.Drawing.Color.Transparent;
            this.InfoBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.InfoBox.Location = new System.Drawing.Point(49, 119);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(217, 58);
            this.InfoBox.TabIndex = 0;
            this.InfoBox.Text = "Hi, Friend How Can I \r\nHelp You";
            this.InfoBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InfoBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // Command
            // 
            this.Command.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Command.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Command.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Command.Location = new System.Drawing.Point(12, 12);
            this.Command.Multiline = true;
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(282, 27);
            this.Command.TabIndex = 3;
            this.Command.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Command.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Reply
            // 
            this.Reply.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reply.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Reply.Location = new System.Drawing.Point(12, 55);
            this.Reply.Multiline = true;
            this.Reply.Name = "Reply";
            this.Reply.Size = new System.Drawing.Size(282, 26);
            this.Reply.TabIndex = 7;
            this.Reply.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Speak_here
            // 
            this.Speak_here.Location = new System.Drawing.Point(12, 312);
            this.Speak_here.Name = "Speak_here";
            this.Speak_here.Size = new System.Drawing.Size(92, 29);
            this.Speak_here.TabIndex = 5;
            this.Speak_here.Text = "Speak Here";
            this.Speak_here.UseVisualStyleBackColor = true;
            this.Speak_here.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(199, 312);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 29);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Visualiser
            // 
            this.Visualiser.Image = global::My_Friend.Properties.Resources.animated_sound_waves;
            this.Visualiser.Location = new System.Drawing.Point(12, 202);
            this.Visualiser.Name = "Visualiser";
            this.Visualiser.Size = new System.Drawing.Size(282, 72);
            this.Visualiser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Visualiser.TabIndex = 8;
            this.Visualiser.TabStop = false;
            this.Visualiser.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // My_Friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 353);
            this.Controls.Add(this.Visualiser);
            this.Controls.Add(this.Reply);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Speak_here);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.InfoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "My_Friend";
            this.Text = "MyFriend";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Visualiser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoBox;
        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.TextBox Reply;
        private System.Windows.Forms.PictureBox Visualiser;
        private System.Windows.Forms.Button Speak_here;
        private System.Windows.Forms.Button Exit;

    }
}


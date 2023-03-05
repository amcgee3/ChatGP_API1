using System;

namespace HATCH_2023
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.responseTXT = new System.Windows.Forms.TextBox();
            this.questionTXT = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.voiceBTN = new System.Windows.Forms.Button();
            this.exportBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rapBTN = new System.Windows.Forms.Button();
            this.twitterBTN = new System.Windows.Forms.Button();
            this.blogBTN = new System.Windows.Forms.Button();
            this.essayBTN = new System.Windows.Forms.Button();
            this.jokeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // responseTXT
            // 
            this.responseTXT.BackColor = System.Drawing.Color.Maroon;
            this.responseTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseTXT.ForeColor = System.Drawing.Color.White;
            this.responseTXT.Location = new System.Drawing.Point(13, 13);
            this.responseTXT.Multiline = true;
            this.responseTXT.Name = "responseTXT";
            this.responseTXT.ReadOnly = true;
            this.responseTXT.Size = new System.Drawing.Size(882, 400);
            this.responseTXT.TabIndex = 0;
            this.responseTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // questionTXT
            // 
            this.questionTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTXT.Location = new System.Drawing.Point(175, 434);
            this.questionTXT.Name = "questionTXT";
            this.questionTXT.Size = new System.Drawing.Size(728, 30);
            this.questionTXT.TabIndex = 1;
            this.questionTXT.Text = "Write your request here....";
            // 
            // submitBTN
            // 
            this.submitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBTN.Location = new System.Drawing.Point(919, 434);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(206, 34);
            this.submitBTN.TabIndex = 2;
            this.submitBTN.Text = "Talk to me";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // voiceBTN
            // 
            this.voiceBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voiceBTN.Location = new System.Drawing.Point(12, 433);
            this.voiceBTN.Name = "voiceBTN";
            this.voiceBTN.Size = new System.Drawing.Size(156, 32);
            this.voiceBTN.TabIndex = 3;
            this.voiceBTN.Text = "Enable Voice";
            this.voiceBTN.UseVisualStyleBackColor = true;
            this.voiceBTN.Click += new System.EventHandler(this.voiceBTN_Click);
            // 
            // exportBTN
            // 
            this.exportBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBTN.Location = new System.Drawing.Point(901, 12);
            this.exportBTN.Name = "exportBTN";
            this.exportBTN.Size = new System.Drawing.Size(224, 38);
            this.exportBTN.TabIndex = 4;
            this.exportBTN.Text = "Create Transcript";
            this.exportBTN.UseVisualStyleBackColor = true;
            this.exportBTN.Click += new System.EventHandler(this.exportBTN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(901, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Past Conversations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(901, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // rapBTN
            // 
            this.rapBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rapBTN.Location = new System.Drawing.Point(13, 483);
            this.rapBTN.Name = "rapBTN";
            this.rapBTN.Size = new System.Drawing.Size(206, 34);
            this.rapBTN.TabIndex = 7;
            this.rapBTN.Text = "Rap";
            this.rapBTN.UseVisualStyleBackColor = true;
            this.rapBTN.Click += new System.EventHandler(this.rapBTN_Click_1);
            // 
            // twitterBTN
            // 
            this.twitterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterBTN.Location = new System.Drawing.Point(248, 483);
            this.twitterBTN.Name = "twitterBTN";
            this.twitterBTN.Size = new System.Drawing.Size(206, 34);
            this.twitterBTN.TabIndex = 8;
            this.twitterBTN.Text = "Twitter";
            this.twitterBTN.UseVisualStyleBackColor = true;
            this.twitterBTN.Click += new System.EventHandler(this.twitterBTN_Click);
            // 
            // blogBTN
            // 
            this.blogBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blogBTN.Location = new System.Drawing.Point(474, 483);
            this.blogBTN.Name = "blogBTN";
            this.blogBTN.Size = new System.Drawing.Size(206, 34);
            this.blogBTN.TabIndex = 9;
            this.blogBTN.Text = "Blog Post";
            this.blogBTN.UseVisualStyleBackColor = true;
            this.blogBTN.Click += new System.EventHandler(this.blogBTN_Click);
            // 
            // essayBTN
            // 
            this.essayBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.essayBTN.Location = new System.Drawing.Point(697, 483);
            this.essayBTN.Name = "essayBTN";
            this.essayBTN.Size = new System.Drawing.Size(206, 34);
            this.essayBTN.TabIndex = 10;
            this.essayBTN.Text = "Essay";
            this.essayBTN.UseVisualStyleBackColor = true;
            this.essayBTN.Click += new System.EventHandler(this.essayBTN_Click);
            // 
            // jokeBTN
            // 
            this.jokeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jokeBTN.Location = new System.Drawing.Point(919, 483);
            this.jokeBTN.Name = "jokeBTN";
            this.jokeBTN.Size = new System.Drawing.Size(206, 34);
            this.jokeBTN.TabIndex = 11;
            this.jokeBTN.Text = "Joke";
            this.jokeBTN.UseVisualStyleBackColor = true;
            this.jokeBTN.Click += new System.EventHandler(this.jokeBTN_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 533);
            this.Controls.Add(this.jokeBTN);
            this.Controls.Add(this.essayBTN);
            this.Controls.Add(this.blogBTN);
            this.Controls.Add(this.twitterBTN);
            this.Controls.Add(this.rapBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exportBTN);
            this.Controls.Add(this.voiceBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.questionTXT);
            this.Controls.Add(this.responseTXT);
            this.Name = "Dashboard";
            this.Text = "Chat with me";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void rapBTN_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox responseTXT;
        private System.Windows.Forms.TextBox questionTXT;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button voiceBTN;
        private System.Windows.Forms.Button exportBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rapBTN;
        private System.Windows.Forms.Button twitterBTN;
        private System.Windows.Forms.Button blogBTN;
        private System.Windows.Forms.Button essayBTN;
        private System.Windows.Forms.Button jokeBTN;
    }
}


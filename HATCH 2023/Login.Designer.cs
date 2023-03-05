namespace HATCH_2023
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLBL = new System.Windows.Forms.Label();
            this.userTXT = new System.Windows.Forms.TextBox();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.newBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLBL.Location = new System.Drawing.Point(108, 269);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(113, 25);
            this.userLBL.TabIndex = 1;
            this.userLBL.Text = "Username: ";
            // 
            // userTXT
            // 
            this.userTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTXT.Location = new System.Drawing.Point(242, 266);
            this.userTXT.Name = "userTXT";
            this.userTXT.Size = new System.Drawing.Size(289, 30);
            this.userTXT.TabIndex = 0;
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLBL.Location = new System.Drawing.Point(108, 309);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(109, 25);
            this.passwordLBL.TabIndex = 1;
            this.passwordLBL.Text = "Password: ";
            // 
            // passwordTXT
            // 
            this.passwordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTXT.Location = new System.Drawing.Point(242, 306);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '*';
            this.passwordTXT.Size = new System.Drawing.Size(289, 30);
            this.passwordTXT.TabIndex = 1;
            // 
            // submitBTN
            // 
            this.submitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBTN.Location = new System.Drawing.Point(111, 361);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(110, 43);
            this.submitBTN.TabIndex = 2;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // newBTN
            // 
            this.newBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBTN.Location = new System.Drawing.Point(247, 361);
            this.newBTN.Name = "newBTN";
            this.newBTN.Size = new System.Drawing.Size(154, 43);
            this.newBTN.TabIndex = 3;
            this.newBTN.Text = "New Account";
            this.newBTN.UseVisualStyleBackColor = true;
            this.newBTN.Click += new System.EventHandler(this.newBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBTN.Location = new System.Drawing.Point(421, 361);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(110, 43);
            this.cancelBTN.TabIndex = 4;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 451);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.newBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.userTXT);
            this.Controls.Add(this.passwordLBL);
            this.Controls.Add(this.userLBL);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLBL;
        public System.Windows.Forms.TextBox userTXT;
        private System.Windows.Forms.Label passwordLBL;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button newBTN;
        private System.Windows.Forms.Button cancelBTN;
    }
}
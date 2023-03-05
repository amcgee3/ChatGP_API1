namespace HATCH_2023
{
    partial class NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            this.firstLBL = new System.Windows.Forms.Label();
            this.firstTXT = new System.Windows.Forms.TextBox();
            this.lastLBL = new System.Windows.Forms.Label();
            this.lastTXT = new System.Windows.Forms.TextBox();
            this.userLBL = new System.Windows.Forms.Label();
            this.userTXT = new System.Windows.Forms.TextBox();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.typeLBL = new System.Windows.Forms.Label();
            this.typeTXT = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstLBL
            // 
            this.firstLBL.AutoSize = true;
            this.firstLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLBL.Location = new System.Drawing.Point(12, 241);
            this.firstLBL.Name = "firstLBL";
            this.firstLBL.Size = new System.Drawing.Size(117, 25);
            this.firstLBL.TabIndex = 0;
            this.firstLBL.Text = "First Name: ";
            // 
            // firstTXT
            // 
            this.firstTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTXT.Location = new System.Drawing.Point(135, 238);
            this.firstTXT.Name = "firstTXT";
            this.firstTXT.Size = new System.Drawing.Size(653, 30);
            this.firstTXT.TabIndex = 0;
            // 
            // lastLBL
            // 
            this.lastLBL.AutoSize = true;
            this.lastLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLBL.Location = new System.Drawing.Point(12, 281);
            this.lastLBL.Name = "lastLBL";
            this.lastLBL.Size = new System.Drawing.Size(117, 25);
            this.lastLBL.TabIndex = 0;
            this.lastLBL.Text = "Last Name: ";
            // 
            // lastTXT
            // 
            this.lastTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastTXT.Location = new System.Drawing.Point(135, 278);
            this.lastTXT.Name = "lastTXT";
            this.lastTXT.Size = new System.Drawing.Size(653, 30);
            this.lastTXT.TabIndex = 1;
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLBL.Location = new System.Drawing.Point(12, 321);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(113, 25);
            this.userLBL.TabIndex = 0;
            this.userLBL.Text = "Username: ";
            // 
            // userTXT
            // 
            this.userTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTXT.Location = new System.Drawing.Point(135, 318);
            this.userTXT.Name = "userTXT";
            this.userTXT.Size = new System.Drawing.Size(653, 30);
            this.userTXT.TabIndex = 2;
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLBL.Location = new System.Drawing.Point(12, 361);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(109, 25);
            this.passwordLBL.TabIndex = 0;
            this.passwordLBL.Text = "Password: ";
            // 
            // passwordTXT
            // 
            this.passwordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTXT.Location = new System.Drawing.Point(135, 356);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '*';
            this.passwordTXT.Size = new System.Drawing.Size(653, 30);
            this.passwordTXT.TabIndex = 3;
            // 
            // typeLBL
            // 
            this.typeLBL.AutoSize = true;
            this.typeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLBL.Location = new System.Drawing.Point(12, 399);
            this.typeLBL.Name = "typeLBL";
            this.typeLBL.Size = new System.Drawing.Size(145, 25);
            this.typeLBL.TabIndex = 0;
            this.typeLBL.Text = "Account Type: ";
            // 
            // typeTXT
            // 
            this.typeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTXT.FormattingEnabled = true;
            this.typeTXT.Items.AddRange(new object[] {
            "Researcher",
            "Fact Checker"});
            this.typeTXT.Location = new System.Drawing.Point(152, 396);
            this.typeTXT.Name = "typeTXT";
            this.typeTXT.Size = new System.Drawing.Size(636, 33);
            this.typeTXT.TabIndex = 4;
            this.typeTXT.Text = "Choose from the drop down menu";
            this.typeTXT.SelectedIndexChanged += new System.EventHandler(this.typeTXT_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // submitBTN
            // 
            this.submitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBTN.Location = new System.Drawing.Point(188, 443);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(129, 44);
            this.submitBTN.TabIndex = 5;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBTN.Location = new System.Drawing.Point(480, 443);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(129, 44);
            this.cancelBTN.TabIndex = 6;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 499);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.typeTXT);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.userTXT);
            this.Controls.Add(this.lastTXT);
            this.Controls.Add(this.firstTXT);
            this.Controls.Add(this.typeLBL);
            this.Controls.Add(this.passwordLBL);
            this.Controls.Add(this.userLBL);
            this.Controls.Add(this.lastLBL);
            this.Controls.Add(this.firstLBL);
            this.Name = "NewAccount";
            this.Text = "New Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLBL;
        private System.Windows.Forms.TextBox firstTXT;
        private System.Windows.Forms.Label lastLBL;
        private System.Windows.Forms.TextBox lastTXT;
        private System.Windows.Forms.Label userLBL;
        private System.Windows.Forms.TextBox userTXT;
        private System.Windows.Forms.Label passwordLBL;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label typeLBL;
        private System.Windows.Forms.ComboBox typeTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button cancelBTN;
    }
}
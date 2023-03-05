namespace HATCH_2023
{
    partial class SelectConversation
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
            this.cancelBTN = new System.Windows.Forms.Button();
            this.selectBTN = new System.Windows.Forms.Button();
            this.selectTXT = new System.Windows.Forms.ComboBox();
            this.selectLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBTN
            // 
            this.cancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBTN.Location = new System.Drawing.Point(363, 55);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(186, 33);
            this.cancelBTN.TabIndex = 5;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // selectBTN
            // 
            this.selectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBTN.Location = new System.Drawing.Point(639, 6);
            this.selectBTN.Name = "selectBTN";
            this.selectBTN.Size = new System.Drawing.Size(186, 33);
            this.selectBTN.TabIndex = 6;
            this.selectBTN.Text = "View Selection";
            this.selectBTN.UseVisualStyleBackColor = true;
            this.selectBTN.Click += new System.EventHandler(this.selectBTN_Click);
            // 
            // selectTXT
            // 
            this.selectTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTXT.FormattingEnabled = true;
            this.selectTXT.Location = new System.Drawing.Point(116, 6);
            this.selectTXT.Name = "selectTXT";
            this.selectTXT.Size = new System.Drawing.Size(511, 33);
            this.selectTXT.TabIndex = 4;
            this.selectTXT.SelectedIndexChanged += new System.EventHandler(this.selectTXT_SelectedIndexChanged);
            // 
            // selectLBL
            // 
            this.selectLBL.AutoSize = true;
            this.selectLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLBL.Location = new System.Drawing.Point(12, 9);
            this.selectLBL.Name = "selectLBL";
            this.selectLBL.Size = new System.Drawing.Size(114, 25);
            this.selectLBL.TabIndex = 3;
            this.selectLBL.Text = "Select File: ";
            // 
            // SelectConversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 101);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.selectBTN);
            this.Controls.Add(this.selectTXT);
            this.Controls.Add(this.selectLBL);
            this.Name = "SelectConversation";
            this.Text = "SelectConversation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button selectBTN;
        private System.Windows.Forms.ComboBox selectTXT;
        private System.Windows.Forms.Label selectLBL;
    }
}
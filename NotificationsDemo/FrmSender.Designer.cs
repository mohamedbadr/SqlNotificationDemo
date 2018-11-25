namespace NotificationsDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRecieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items Count";
            // 
            // TxtCount
            // 
            this.TxtCount.Enabled = false;
            this.TxtCount.Location = new System.Drawing.Point(23, 172);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(292, 20);
            this.TxtCount.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(23, 13);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(292, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add New Item";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRecieve
            // 
            this.BtnRecieve.Location = new System.Drawing.Point(23, 104);
            this.BtnRecieve.Name = "BtnRecieve";
            this.BtnRecieve.Size = new System.Drawing.Size(292, 23);
            this.BtnRecieve.TabIndex = 3;
            this.BtnRecieve.Text = "Reciever Form";
            this.BtnRecieve.UseVisualStyleBackColor = true;
            this.BtnRecieve.Click += new System.EventHandler(this.BtnRecieve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 217);
            this.Controls.Add(this.BtnRecieve);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRecieve;
    }
}


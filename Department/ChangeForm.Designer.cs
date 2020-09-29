namespace Department
{
    partial class ChangeForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxOldHead = new System.Windows.Forms.TextBox();
            this.textBoxNewHead = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(224, 241);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxOldHead
            // 
            this.textBoxOldHead.Location = new System.Drawing.Point(16, 124);
            this.textBoxOldHead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOldHead.Name = "textBoxOldHead";
            this.textBoxOldHead.Size = new System.Drawing.Size(241, 22);
            this.textBoxOldHead.TabIndex = 1;
            this.textBoxOldHead.Text = "Previous head...";
            // 
            // textBoxNewHead
            // 
            this.textBoxNewHead.Location = new System.Drawing.Point(300, 124);
            this.textBoxNewHead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNewHead.Name = "textBoxNewHead";
            this.textBoxNewHead.Size = new System.Drawing.Size(241, 22);
            this.textBoxNewHead.TabIndex = 1;
            this.textBoxNewHead.Text = "New head...";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(300, 174);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(241, 22);
            this.textBoxNewPassword.TabIndex = 1;
            this.textBoxNewPassword.Text = "New password...";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(16, 174);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(241, 22);
            this.textBoxOldPassword.TabIndex = 1;
            this.textBoxOldPassword.Text = "Old password...";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 290);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewHead);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.textBoxOldHead);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.TextBox textBoxOldHead;
        public System.Windows.Forms.TextBox textBoxNewHead;
        public System.Windows.Forms.TextBox textBoxNewPassword;
        public System.Windows.Forms.TextBox textBoxOldPassword;
    }
}
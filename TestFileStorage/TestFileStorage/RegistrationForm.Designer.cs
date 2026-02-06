namespace TestFileStorage
{
    partial class RegistrationForm
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
            this.LoginComboBox = new System.Windows.Forms.ComboBox();
            this.registrButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginComboBox
            // 
            this.LoginComboBox.FormattingEnabled = true;
            this.LoginComboBox.Location = new System.Drawing.Point(120, 12);
            this.LoginComboBox.Name = "LoginComboBox";
            this.LoginComboBox.Size = new System.Drawing.Size(100, 21);
            this.LoginComboBox.TabIndex = 10;
            // 
            // registrButton
            // 
            this.registrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrButton.Location = new System.Drawing.Point(27, 74);
            this.registrButton.Name = "registrButton";
            this.registrButton.Size = new System.Drawing.Size(165, 32);
            this.registrButton.TabIndex = 9;
            this.registrButton.Text = "Зарегистрироваться";
            this.registrButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите пароль:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(120, 41);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите логин:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 155);
            this.Controls.Add(this.LoginComboBox);
            this.Controls.Add(this.registrButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LoginComboBox;
        private System.Windows.Forms.Button registrButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
    }
}
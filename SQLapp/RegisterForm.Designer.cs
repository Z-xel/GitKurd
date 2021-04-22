﻿
namespace SQLapp
{
  partial class RegisterForm
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
      this.ExitButton = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonRegister = new System.Windows.Forms.Button();
      this.userNameField = new System.Windows.Forms.TextBox();
      this.userSurnameField = new System.Windows.Forms.TextBox();
      this.passField = new System.Windows.Forms.TextBox();
      this.loginField = new System.Windows.Forms.TextBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // ExitButton
      // 
      this.ExitButton.AutoSize = true;
      this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
      this.ExitButton.Location = new System.Drawing.Point(769, 9);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(19, 18);
      this.ExitButton.TabIndex = 8;
      this.ExitButton.Text = "Х";
      this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
      this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.SystemColors.Control;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(800, 105);
      this.label1.TabIndex = 7;
      this.label1.Text = "Регистрация";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
      this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
      // 
      // buttonRegister
      // 
      this.buttonRegister.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.buttonRegister.Location = new System.Drawing.Point(565, 271);
      this.buttonRegister.Name = "buttonRegister";
      this.buttonRegister.Size = new System.Drawing.Size(174, 35);
      this.buttonRegister.TabIndex = 13;
      this.buttonRegister.Text = "Зарегистрироваться";
      this.buttonRegister.UseVisualStyleBackColor = false;
      this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
      // 
      // userNameField
      // 
      this.userNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.userNameField.Location = new System.Drawing.Point(136, 179);
      this.userNameField.Name = "userNameField";
      this.userNameField.Size = new System.Drawing.Size(236, 29);
      this.userNameField.TabIndex = 14;
      this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
      this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
      // 
      // userSurnameField
      // 
      this.userSurnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.userSurnameField.Location = new System.Drawing.Point(136, 229);
      this.userSurnameField.Name = "userSurnameField";
      this.userSurnameField.Size = new System.Drawing.Size(236, 29);
      this.userSurnameField.TabIndex = 15;
      this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
      this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
      // 
      // passField
      // 
      this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.passField.Location = new System.Drawing.Point(529, 179);
      this.passField.Name = "passField";
      this.passField.Size = new System.Drawing.Size(210, 32);
      this.passField.TabIndex = 17;
      this.passField.UseSystemPasswordChar = true;
      // 
      // loginField
      // 
      this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
      this.loginField.Location = new System.Drawing.Point(136, 277);
      this.loginField.Name = "loginField";
      this.loginField.Size = new System.Drawing.Size(236, 29);
      this.loginField.TabIndex = 18;
      this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
      this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackgroundImage = global::SQLapp.Properties.Resources._lock;
      this.pictureBox2.Image = global::SQLapp.Properties.Resources._lock;
      this.pictureBox2.InitialImage = global::SQLapp.Properties.Resources._lock;
      this.pictureBox2.Location = new System.Drawing.Point(449, 179);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(64, 64);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 19;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.WaitOnLoad = true;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::SQLapp.Properties.Resources.user;
      this.pictureBox1.Location = new System.Drawing.Point(49, 179);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(64, 64);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 16;
      this.pictureBox1.TabStop = false;
      // 
      // RegisterForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.WindowFrame;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.passField);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.loginField);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.userSurnameField);
      this.Controls.Add(this.userNameField);
      this.Controls.Add(this.buttonRegister);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "RegisterForm";
      this.Text = "RegisterForm";
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label ExitButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonRegister;
    private System.Windows.Forms.TextBox userNameField;
    private System.Windows.Forms.TextBox userSurnameField;
    private System.Windows.Forms.TextBox passField;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.TextBox loginField;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}
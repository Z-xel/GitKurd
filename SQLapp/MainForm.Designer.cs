
namespace SQLapp
{
  partial class MainForm
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.WindowFrame;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ExitButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label ExitButton;
  }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLapp
{
  public partial class MainForm : Form
  {

    Point lastPoint;
    public MainForm()
    {
      InitializeComponent();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void ExitButton_MouseEnter(object sender, EventArgs e)
    {
      ExitButton.ForeColor = Color.DarkGray;
    }

    private void ExitButton_MouseLeave(object sender, EventArgs e)
    {
      ExitButton.ForeColor = Color.White;
    }

    private void MainForm_MouseDown(object sender, MouseEventArgs e)
    {
      lastPoint = new Point(e.X, e.Y);
    }

    private void MainForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Left += e.X - lastPoint.X;
        Top += e.Y - lastPoint.Y;
      }
    }
  }
}
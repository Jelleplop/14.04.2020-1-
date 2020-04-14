using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._04._2020__1_
{
    public partial class Form1 : Form


    {
        private int speed_vertical = 2;
        private int speed_hor = 2;
        private int score = 0;



            public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;

            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;

            gamePanel.Top = back.Bottom - (back.Bottom / 10);



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);

            gamebol.Left += speed_hor;
            gamebol.Top += speed_vertical;


            if (gamebol.Left <= back.Left)
                speed_hor *= -1;

            if (gamebol.Right <= back.Right)
                speed_hor *= -1;

            if (gamebol.Top <= back.Top)
                speed_vertical *= -1;

            if (gamebol.Bottom >= back.Bottom)
                timer.Enabled = false;


            if (gamebol.Bottom >= gamePanel.Top && gamebol.Bottom <= gamePanel.Bottom && gamebol.Left >= gamePanel.Left && gamebol.Right <= gamePanel.Right)



            speed_hor += 2;
            speed_vertical += 2;
            speed_vertical *= -1;
            score += 1;
        }

    }
}

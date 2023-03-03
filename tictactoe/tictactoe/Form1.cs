using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        char who = 'o';
        short movement = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
           Button? bt = sender as Button;
           bt.Enabled = false; 
           bt.BackColor= Color.Red;
           if (who== 'o')
            {
                bt.Text = "o";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "")||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "")||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "")||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "")||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "")||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "")||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "")||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show($"Nyert a {who.ToString().ToUpper()} játékos"); 
                }

                who = 'x';
            } 

           else if (who== 'x')
            {
                bt.Text = "x";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show($"Nyert a {who.ToString().ToUpper()} játékos");
                }
                who = 'o';
            }
           if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != "" && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                MessageBox.Show("Döntetlen lett");
            }
            
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztos új játékot akarsz indítani?",
                     "New Game", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    b1.Enabled = true; b2.Enabled = true; b3.Enabled = true; b4.Enabled = true;
                    b8.Enabled = true; b7.Enabled = true; b6.Enabled = true; b5.Enabled = true;
                    b9.Enabled = true;
                    b1.Text = "";
                    b1.BackColor = Color.White;
                    b2.Text = "";
                    b2.BackColor = Color.White;
                    b3.Text = "";
                    b3.BackColor = Color.White;
                    b4.Text = "";
                    b4.BackColor = Color.White;
                    b5.Text = "";
                    b5.BackColor = Color.White;
                    b6.Text = "";
                    b6.BackColor = Color.White;
                    b7.Text = "";
                    b7.BackColor = Color.White;
                    b8.Text = "";
                    b8.BackColor = Color.White;
                    b9.Text = "";
                    b9.BackColor = Color.White;
                    break;
                case DialogResult.No:
                    break;
            }


        }
    }
}
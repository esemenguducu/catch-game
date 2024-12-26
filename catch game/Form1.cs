using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catch_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form başlatıldığında butonun özellikleri 
            button1.Text = "catch me if you can";
            button1.Width = 100;
            button1.Height = 50; 
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
            int newX = random.Next(0, this.ClientSize.Width - button1.Width);
            int newY = random.Next(0, this.ClientSize.Height - button1.Height);

            button1.Left = newX;
            button1.Top = newY;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Tebrikler! Beni yakaladın!", "Oyun Bitti");
        }

       
    }
}

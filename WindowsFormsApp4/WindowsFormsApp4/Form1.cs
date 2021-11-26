using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void m1()
        {
            for(int i =0; i<100;i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Yellow, 4), new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);

            }
        }
        public void m2()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);

            }
        }
        Random rnd;
        Thread t1;
        Thread t2;
       
        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ma12 = new Thread(m1);
            ma12.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Thread ma1 = new Thread(m2);
            ma1.Start();

        }
    }
}

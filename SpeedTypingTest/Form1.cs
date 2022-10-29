using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpeedTypingTest
{
    public partial class Form1 : Form
    {
        int minute, second;
       // TextBox td = new TextBox();
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "hello there This is a speed typing tester";
            timer1.Start();
            textBox2.ReadOnly = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // timer1.Stop();
            char c;
            textBox3.Text = "";
            //word count
            int cn = 0;
            //
            string txt = textBox1.Text;
            //sample text
            string txt2 = textBox2.Text;

            string[] str1 = txt2.Split(' ');
            string[] str2 = txt.Split(' ');
            char[] sep = { ' ' };
            int cnt = txt.Split(sep, StringSplitOptions.RemoveEmptyEntries).Length;
            textBox4.Text = cnt.ToString();
            //int j=0, k, l;
            int correct = 0;
            int mn = Math.Min(str1.Length, str2.Length);
           // int mn1 = Math.Min(txt.Length, txt2.Length);

            for (int i = 0; i < mn; i++)
            {
                cn = cn + 1;
                if (str1[i] == str2[i])
                {
                    correct++;
                    
                }
               
                
            }
            Console.WriteLine("correct:" + correct + "\n");
            //accuracy
            double ac = Convert.ToDouble(correct) / Convert.ToDouble(cnt);
            ac = ac * 100;
            //String.Format("{0:0.00}", ac);
            ac = System.Math.Round(ac, 3);
            textBox3.Text = ac.ToString() + "%";
            
            //speed
            double sp;
            double res = ((Convert.ToDouble(minute) * 60) + Convert.ToDouble(second)) / 60;
            Console.WriteLine("res =" + res + "\n");

            sp = Math.Round(correct / res);
           // Console.WriteLine("sp=" + sp + "\n");
            textBox5.Text = sp.ToString();
            Console.WriteLine("str1>length:" + str1.Length + "\n");
            Console.WriteLine("cn:" + cn + "\n");
            if (str1.Length+1 == str2.Length)
            {
                timer1.Stop();
                textBox1.ReadOnly = true;
            }

        }
        //reset button
        private void button1_Click(object sender, EventArgs e)
        {
            
            sec = 0;
            textBox1.ReadOnly = false;
            textBox1.Text = "";
            //textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            timer1.Start();
            
 
        }
        int sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = sec + 1;
             minute = sec/60 ;
             second =sec%60 ;
            timelbl.Text = "" + minute + " :" + second + " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox1Click(object sender, EventArgs e)
        {
            //extbox1Click tb2 = new textBox2_TextChanged();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

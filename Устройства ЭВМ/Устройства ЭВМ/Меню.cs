using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Устройства_ЭВМ
{
    public partial class Меню : Form
    {
        Form Form1;
        bool first = true;
        
        public Меню()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
       /* private void AllHideForm()
        {
            Form1.Hide();Form2.Hide();Form3.Hide();
            Form4.Hide();Form5.Hide();Form6.Hide();
            panel1.BackgroundImage = null;
        }*/


        private void panel1_Resize(object sender, EventArgs e)
        {
            if (first == false)
                Form1.Size = panel1.Size;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            if (first == true)
                first = false;
            else
                Form1.Close();
            Form1 = new Архитектура_ЭВМ();
            Form1.TopLevel = false;
            panel1.Controls.Add(Form1); Form1.Size = panel1.Size;
            Form1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            if (first == true)
                first = false;
            else
                Form1.Close();
            Form1 = new Устройства_обработки_информации();
            Form1.TopLevel = false;
            panel1.Controls.Add(Form1); Form1.Size = panel1.Size;
            Form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            if (first == true)
                first = false;
            else
                Form1.Close();
            Form1 = new Устройства_хранения_информации();
            Form1.TopLevel = false;
            panel1.Controls.Add(Form1); Form1.Size = panel1.Size;
            Form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            if (first == true)
                first = false;
            else
                Form1.Close();
            Form1 = new Устройства_ввода_информации();
            Form1.TopLevel = false;
            panel1.Controls.Add(Form1); Form1.Size = panel1.Size;
            Form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            if (first == true)
                first = false;
            else
                Form1.Close();
            Form1 = new Устройства_вывода_информации();
            Form1.TopLevel = false;
            panel1.Controls.Add(Form1); Form1.Size = panel1.Size;
            Form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            if (first == true)
                first = false;
            else
                Form1.Close();
            Form1 = new Устройства_передачи_информации();
            Form1.TopLevel = false;
            panel1.Controls.Add(Form1); Form1.Size = panel1.Size;
            Form1.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Библиотека_функций;

namespace Устройства_ЭВМ
{
    public partial class Устройства_вывода_информации : Form
    {
        public Устройства_вывода_информации()
        {
            InitializeComponent();
        }

        private void Устройства_вывода_информации_Resize(object sender, EventArgs e)
        {
            panel1.Size = new Size(tabControl1.Size.Width / 32 * 8, tabControl1.Size.Height / 32 * 16);
            panel1.Location = new Point((this.Size.Width - panel1.Size.Width) / 80, panel1.Location.Y);
            panel2.Size = new Size(tabControl1.Size.Width / 32 * 8, tabControl1.Size.Height / 32 * 16);
            panel2.Location = new Point((this.Size.Width - panel2.Size.Width) / 2, panel2.Location.Y);
            panel3.Size = new Size(tabControl1.Size.Width / 32 * 8, tabControl1.Size.Height / 32 * 16);
            panel3.Location = new Point((this.Size.Width - panel3.Size.Width) / 100, panel3.Location.Y);
            panel4.Size = new Size(tabControl1.Size.Width / 32 * 8, tabControl1.Size.Height / 32 * 16);
            panel4.Location = new Point((this.Size.Width - panel4.Size.Width) / 2, panel4.Location.Y);

            button1.Size = new Size(tabControl1.Size.Width / 12 * 2, button1.Size.Height);
            button1.Location = new Point(tabControl1.Size.Width / 12 * 2, panel4.Location.Y + panel4.Size.Height + 10);
            button2.Size = new Size(tabControl1.Size.Width / 12 * 2, button2.Size.Height);
            button2.Location = new Point(button1.Location.X + button1.Size.Width + tabControl1.Size.Width / 12, button1.Location.Y);
            button3.Size = new Size(tabControl1.Size.Width / 12 * 2, button3.Size.Height);
            button3.Location = new Point(button2.Location.X + button2.Size.Width + tabControl1.Size.Width / 12, button1.Location.Y);

            label1.Location = new Point(panel1.Location.X / 32, panel1.Location.Y + panel1.Size.Height + 30);
            label2.Location = new Point(panel2.Location.X / 32, panel2.Location.Y + panel2.Size.Height + 30);
            label3.Location = new Point(panel3.Location.X + panel3.Size.Width + 10, label3.Location.Y);
            label4.Location = new Point(tabControl1.Size.Width / 100, button1.Location.Y + button1.Size.Height + 10);

            Label lab;
            lab = label1;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 30);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label2;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 30);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label3;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X - 10, tabControl1.Size.Height - lab.Location.Y - 20);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label4;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 30);
            Текст.АвтоРазмерТекста(ref lab);


        }

        private void tabControl1_Layout(object sender, LayoutEventArgs e)
        {
            Устройства_вывода_информации_Resize((object)this, EventArgs.Empty);
        }
        bool first = false;
        Form Form1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (first == false)
                first = true;
            else
                Form1.Close();
            Form1 = new Матричный_принтер();
            Form1.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (first == false)
                first = true;
            else
                Form1.Close();
            Form1 = new Лазерный_принтер();
            Form1.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (first == false)
                first = true;
            else
                Form1.Close();
            Form1 = new Струйный_принтер();
            Form1.Show(); 
        }
    }
}

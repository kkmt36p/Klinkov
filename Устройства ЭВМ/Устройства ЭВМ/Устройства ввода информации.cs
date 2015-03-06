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
    public partial class Устройства_ввода_информации : Form
    {
        public Устройства_ввода_информации()
        {
            InitializeComponent();
        }
        Form Form1;
        bool first = true;

        private void Устройства_ввода_информации_Resize(object sender, EventArgs e)
        {
            panel1.Size = new Size(tabControl1.Size.Width / 32 * 10, tabControl1.Size.Height / 3);
            panel1.Location = new Point((this.Size.Width - panel1.Size.Width) / 2, panel1.Location.Y);
            panel2.Size = new Size(tabControl1.Size.Width / 32 * 10, tabControl1.Size.Height / 3);
            panel2.Location = new Point((this.Size.Width - panel1.Size.Width) / 2, panel1.Location.Y);
            panel3.Size = new Size(tabControl1.Size.Width / 32 * 8, tabControl1.Size.Height / 3);
            panel3.Location = new Point((this.Size.Width - panel1.Size.Width) / 2, panel1.Location.Y);
            panel4.Size = new Size(tabControl1.Size.Width / 32 * 8, tabControl1.Size.Height / 3);
            panel4.Location = new Point((this.Size.Width - panel1.Size.Width) / 2, panel1.Location.Y);
            panel5.Size = new Size(tabControl1.Size.Width / 32 * 8, tabControl1.Size.Height / 3);
            panel5.Location = new Point((this.Size.Width - panel1.Size.Width) / 2, panel1.Location.Y);
            panel6.Size = new Size(tabControl1.Size.Width / 32 * 7, tabControl1.Size.Height / 3);
            panel6.Location = new Point((this.Size.Width - panel1.Size.Width) / 2, panel1.Location.Y);
            panel7.Size = new Size(tabControl1.Size.Width / 32 * 7, tabControl1.Size.Height / 3);
            panel7.Location = new Point((this.Size.Width - panel1.Size.Width) / 2, panel1.Location.Y);
            panel8.Size = new Size(tabControl1.Size.Width / 32 * 7, tabControl1.Size.Height / 3);
            panel8.Location = new Point((this.Size.Width - panel1.Size.Width) / 2, panel1.Location.Y);

            panel9.Size = new Size(tabControl1.Size.Width / 12 * 3, tabControl1.Size.Height / 3);
            panel9.Location = new Point(tabControl1.Size.Width / 12 * 1, tabControl1.Size.Height / 100 * 15);
            panel10.Size = new Size(tabControl1.Size.Width / 12 * 3, tabControl1.Size.Height / 3);
            panel10.Location = new Point(panel9.Location.X + tabControl1.Size.Width / 12 * 6, tabControl1.Size.Height / 100 * 15);

            button1.Size = button2.Size = button3.Size = new Size(tabControl1.Size.Width / 4, button1.Size.Height);
            button1.Location = new Point(tabControl1.Size.Width / 4 / 3 / 2, panel1.Location.Y + panel1.Size.Height + 10);
            button2.Location = new Point(button1.Location.X + button1.Size.Width + tabControl1.Size.Width / 4 / 3, button1.Location.Y);
            button3.Location = new Point(button2.Location.X + button2.Size.Width + tabControl1.Size.Width / 4 / 3, button1.Location.Y);
            label1.Location = new Point(button1.Location.X, button1.Location.Y + button1.Size.Height + 10);
            label2.Location = new Point(label2.Location.X, panel2.Location.Y + panel2.Size.Height + 10);
            label3.Location = new Point(label2.Location.X, panel3.Location.Y + panel3.Size.Height + 10);
            label4.Location = new Point(label2.Location.X, panel3.Location.Y + panel3.Size.Height + 10);
            label5.Location = new Point(label2.Location.X, panel3.Location.Y + panel3.Size.Height + 10);
            label6.Location = new Point(label2.Location.X, panel3.Location.Y + panel3.Size.Height + 10);
            label7.Location = new Point(label2.Location.X, panel3.Location.Y + panel3.Size.Height + 10);
            label8.Location = new Point(label2.Location.X, panel3.Location.Y + panel3.Size.Height + 10);
            label11.Location = new Point(label2.Location.X, tabControl1.Size.Height / 2);

            Label lab;
            lab = label1;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label2;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label3;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label4;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label5;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label6;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label7;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label8;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label11;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);

            label9.Location = new Point(panel9.Location.X + panel9.Size.Width / 2 - label9.Size.Width / 2, panel9.Location.Y - label9.Size.Height);
            label10.Location = new Point(panel10.Location.X + panel10.Size.Width / 2 - label10.Size.Width / 2, panel10.Location.Y - label10.Size.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (first == true)
                first = false;
            else
                Form1.Close();
            Form1 = new Размещение_групп_клавиш();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (first == true)
                first = false;
            else
                Form1.Close();
            Form1 = new Стандартные_клавиши();
            Form1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (first == true)
                first = false;
            else
                Form1.Close();
            Form1 = new Комбинации_клавиш();
            Form1.Show();
        }

        private void Устройства_ввода_информации_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (first == true)
                first = false;
            else
                Form1.Close();
        }

        private void tabControl1_Layout(object sender, LayoutEventArgs e)
        {
            Устройства_ввода_информации_Resize((object)this, EventArgs.Empty);
        }
    }
}


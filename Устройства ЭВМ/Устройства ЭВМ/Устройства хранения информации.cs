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
    public partial class Устройства_хранения_информации : Form
    {
        public Устройства_хранения_информации()
        {
            InitializeComponent();
            OldSize = label3.Size;
            label5.Text = "Основными видами внешних носителей информации являются диски и магнитные ленты.\nВнешняя память имеет две важных особенности по сравнению с оперативной памятью: \n1. Для хранения данных не требуется электропитания. \n2. Во внешней памяти можно хранить большие объемы информации. \nНаиболее распространенными устройствами долговременного хранения информации являются диски. В ПК используются различные виды дисков: стационарные жесткие диски, сменные гибкие диски и оптические диски, обладающие очень большой емкостью и надежностью.";
        }
        Size OldSize;
        private void Устройства_хранения_информации_Resize(object sender, EventArgs e)
        {
            panel1.Size = new Size(tabControl1.Size.Width / 32 * 27, tabControl1.Size.Height / 3);
            button1.Size = button2.Size = button3.Size = button4.Size = new Size(panel1.Size.Width / 5, button1.Size.Height);
            button1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y + panel1.Size.Height + 10);
            button2.Location = new Point(button1.Location.X + button1.Size.Width + button1.Size.Width / 5, button1.Location.Y);
            button3.Location = new Point(button2.Location.X + button2.Size.Width + button1.Size.Width / 5, button1.Location.Y);
            button4.Location = new Point(button3.Location.X + button3.Size.Width + button1.Size.Width / 5, button1.Location.Y);
            label5.Location = new Point(button1.Location.X, button1.Location.Y + button1.Size.Height + 10);
            label5.Size = new Size(button1.Size.Width * 4 + button1.Size.Width / 5 * 3, this.Size.Height / 8 * 3);

            Label lab;
            lab = label3;
            lab.Size = new Size(this.Size.Width / 2, lab.Size.Height);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label4;
            lab.Size = new Size(this.Size.Width / 2, lab.Size.Height);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label5;
            Текст.АвтоРазмерТекста(ref lab);

        }

        Form Form1;
        bool first = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (first == false)
                first = true;
            else
                Form1.Close();
            Form1 = new Гибкие_диски();
            Form1.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (first == false)
                first = true;
            else
                Form1.Close();
            Form1 = new Жёсткие_диски();
            Form1.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (first == false)
                first = true;
            else
                Form1.Close();
            Form1 = new Устройства_ЭВМ.Формы_Устр._хран._инфо.Оптические_диски();
            Form1.Show(); 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (first == false)
                first = true;
            else
                Form1.Close();
            Form1 = new Устройства_ЭВМ.Формы_Устр._хран._инфо.Магнитные_ленты();
            Form1.Show(); 

        }

        private void tabControl1_Layout(object sender, LayoutEventArgs e)
        {
            Устройства_хранения_информации_Resize(((object)this), EventArgs.Empty);
        }
    }
}

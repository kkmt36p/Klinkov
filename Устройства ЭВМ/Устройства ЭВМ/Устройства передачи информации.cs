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
    public partial class Устройства_передачи_информации : Form
    {
        public Устройства_передачи_информации()
        {
            InitializeComponent();
            label1.Text += "\nМодем - устройство, предназначенное для преобразования и передачи данных между удаленными компьютерами.";
        }

        private void Устройства_передачи_информации_Resize(object sender, EventArgs e)
        {
            panel1.Size = new Size(tabControl1.Size.Width / 3, tabControl1.Size.Height / 2);
            panel1.Location = new Point((tabControl1.Size.Width + panel1.Size.Width) / 4, tabControl1.Size.Height/ 100 * 5);
            label1.Size = new Size(tabControl1.Size.Width - 20,tabControl1.Size.Height - panel1.Size.Height - panel1.Location.Y - 20);
            label1.Location = new Point(10,panel1.Location.Y + panel1.Size.Height + 20);
            panel2.Size = new Size(tabControl1.Size.Width / 3, tabControl1.Size.Height / 2);
            panel2.Location = new Point((tabControl1.Size.Width + panel2.Size.Width) / 4, tabControl1.Size.Height / 100 * 5);
            label2.Size = new Size(tabControl1.Size.Width - 20, tabControl1.Size.Height - panel2.Size.Height - panel2.Location.Y - 20);
            label2.Location = new Point(10, panel2.Location.Y + panel2.Size.Height + 20);

            Label lab;
            lab = label1;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label2;
            lab.Size = new Size(tabControl1.Size.Width - lab.Location.X * 2, tabControl1.Size.Height - lab.Location.Y - 40);
            Текст.АвтоРазмерТекста(ref lab);
        }
        private void tabControl1_Layout(object sender, LayoutEventArgs e)
        {
            Устройства_передачи_информации_Resize((object)this, EventArgs.Empty);
        }
    }
}

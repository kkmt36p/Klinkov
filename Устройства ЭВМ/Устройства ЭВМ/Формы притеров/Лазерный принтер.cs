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
    public partial class Лазерный_принтер : Form
    {
        public Лазерный_принтер()
        {
            InitializeComponent();
            Старый_размер_формы = this.Size;
            Лазерный_принтер_Resize((object)this, EventArgs.Empty);
        }
        Size Старый_размер_формы;
        private void Лазерный_принтер_Resize(object sender, EventArgs e)
        {
            panel1.Location = Библиотека_функций.Форма.АвтоКорректор(panel1.Location, this.Size, Старый_размер_формы);
            panel1.Size = Библиотека_функций.Форма.АвтоКорректор(panel1.Size, this.Size, Старый_размер_формы);
            label1.Location = Библиотека_функций.Форма.АвтоКорректор(label1.Location, this.Size, Старый_размер_формы);
            label1.Size = Библиотека_функций.Форма.АвтоКорректор(label1.Size, this.Size, Старый_размер_формы);
            /*panel1.Location = new Point(this.Size.Width / 3, 10);
            panel1.Size = new Size(this.Size.Width / 3, this.Size.Height / 30 * 10);
            label1.Location = new Point(this.Size.Width / 100, panel1.Location.Y + panel1.Size.Height + 10);
            label1.Size = new Size(this.Size.Width - label1.Location.X * 2 - 10, this.Size.Height - label1.Location.Y - 10);*/
            Библиотека_функций.Текст.АвтоРазмерТекста(ref label1);
            Старый_размер_формы = this.Size;
        }
    }
}

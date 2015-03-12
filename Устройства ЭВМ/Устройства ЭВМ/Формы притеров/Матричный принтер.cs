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
    public partial class Матричный_принтер : Form
    {
        public Матричный_принтер()
        {
            InitializeComponent();
            Старый_размер_формы = this.Size;
            Матричный_принтер_Resize((object)this, EventArgs.Empty);
        }

        Size Старый_размер_формы;

        private void Матричный_принтер_Resize(object sender, EventArgs e)
        {
            panel1.Location = Форма.АвтоКорректор(panel1.Location,this.Size,Старый_размер_формы);
            panel1.Size = Форма.АвтоКорректор(panel1.Size,this.Size,Старый_размер_формы);
            label1.Location = Форма.АвтоКорректор(label1.Location,this.Size,Старый_размер_формы);
            label1.Size = Форма.АвтоКорректор(label1.Size, this.Size, Старый_размер_формы);
            Библиотека_функций.Текст.АвтоРазмерТекста(ref label1);
            Старый_размер_формы = this.Size;
        }
    }
}

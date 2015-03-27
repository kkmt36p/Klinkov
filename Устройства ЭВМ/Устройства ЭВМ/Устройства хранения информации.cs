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
            Старый_размер_формы = label3.Size;
            label3.Text += "\n\nОЗУ большинства современных компьютеров представляет собой модули динамической памяти, содержащие полупроводниковые ИС ЗУ, организованные по принципу устройств с произвольным доступом. Память динамического типа дешевле, чем статического, и её плотность выше, что позволяет на той же площади кремниевого кристалла разместить больше ячеек памяти, но при этом её быстродействие ниже. Статическая память, наоборот, более быстрая память, но она и дороже. В связи с этим основную оперативную память строят на модулях динамической памяти, а память статического типа используется для построения кэш-памяти внутри микропроцессора.";
            label5.Text = "Внешняя память - это память, реализованная в виде внешних запоминающих устройств (ВЗУ) с разными принципами хранения информации.\n" +
                "ВЗУ предназначены для долговременного хранения информации любого вида и характеризуются большим объемом памяти и низким по сравнению с ОЗУ быстродействием.\n" +
                "Под внешней памятью компьютера подразумевают обычно как устройства для чтения / записи информации - накопители, так и устройства, где непосредственно хранится информация - носители информации.\n" +
                "Как правило, для каждого носителя информации существует свой накопитель. А такое устройство как винчестер, совмещает в себе и носитель, и накопитель.\n" +
                "Носителями информации во внешней памяти современных компьютеров являются гибкие, магнитные, жёсткие, оптические диски и т.д..";
            Старый_размер_формы = this.Size;
        }
        Size Старый_размер_формы;
        private void Устройства_хранения_информации_Resize(object sender, EventArgs e)
        {
            Форма.АвтоКорректорОбъекта(ref panel1, this.Size, Старый_размер_формы);
            Форма.АвтоКорректорОбъекта(ref panel2, this.Size, Старый_размер_формы);
            Форма.АвтоКорректорОбъекта(ref panel3, this.Size, Старый_размер_формы);
            Форма.АвтоКорректорОбъекта(ref panel4, this.Size, Старый_размер_формы);   
            Форма.АвтоКорректорОбъекта(ref button1, this.Size, Старый_размер_формы, "Без_высоты");
            Форма.АвтоКорректорОбъекта(ref button2, this.Size, Старый_размер_формы, "Без_высоты");
            Форма.АвтоКорректорОбъекта(ref button3, this.Size, Старый_размер_формы, "Без_высоты");
            Форма.АвтоКорректорОбъекта(ref button4, this.Size, Старый_размер_формы, "Без_высоты");
            Форма.АвтоКорректорОбъекта(ref label5, this.Size, Старый_размер_формы,"да 3,6");


            Label lab;
            lab = label3;
            lab.Size = new Size(this.Size.Width / 2, lab.Size.Height);
            Текст.АвтоРазмерТекста(ref lab);
            lab = label4;
            lab.Size = new Size(this.Size.Width / 2, lab.Size.Height);
            Текст.АвтоРазмерТекста(ref lab);

            Старый_размер_формы = this.Size;
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

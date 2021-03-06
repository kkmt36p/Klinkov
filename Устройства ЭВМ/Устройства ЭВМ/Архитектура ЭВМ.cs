﻿using System;
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
    public partial class Архитектура_ЭВМ : Form
    {
        public Архитектура_ЭВМ()
        {
            InitializeComponent();
            //В своем докладе Джон фон Нейман описал, как должен  быть  устроен компьютер для того, чтобы он был универсальным и  эффективным  устройством для обработки информации. Прежде всего компьютер должен  иметь  следующие устройства: * арифметическо-логическое устройство,  выполняющее  арифметические и логические операции; * устройство управления, которое  организует  процесс  выполнения программы; * запоминающее устройство, или память  для  хранения  программ  и данных; * внешние устройства для ввода-вывода информации. Память компьютера должна состоять из некоторого количества пронумерованных ячеек, в каждой из которых могут находиться  или  обрабатываемые данные, или инструкции программ. Все ячейки памяти должны  быть одинаково легко доступны для других устройств компьютера.
            label2.Text = "В своем докладе Джон фон Нейман описал, как должен  быть  устроен компьютер для того, чтобы он был универсальным и  эффективным  устройством для обработки информации.\nПрежде всего компьютер должен  иметь  следующие устройства:\n     * арифметическо-логическое устройство,  выполняющее  арифметические и логические операции;\n     * устройство управления, которое  организует  процесс  выполнения программы;\n     * запоминающее устройство, или память  для  хранения  программ  и данных;\n     * внешние устройства для ввода-вывода информации.\nПамять компьютера должна состоять из некоторого количества пронумерованных ячеек, в каждой из которых могут находиться  или  обрабатываемые данные, или инструкции программ. Все ячейки памяти должны  быть одинаково легко доступны для других устройств компьютера.";
            Старый_размер_формы = this.Size;
            Архитектура_ЭВМ_Resize((object)this, EventArgs.Empty);
        }
        Size Старый_размер_формы;
        private void Архитектура_ЭВМ_Resize(object sender, EventArgs e)
        {
            panel1.Size = Форма.АвтоКорректор(panel1.Size, this.Size, Старый_размер_формы);
            panel1.Location = Форма.АвтоКорректор(panel1.Location, this.Size, Старый_размер_формы);
            label1.Size = Форма.АвтоКорректор(label1.Size, this.Size, Старый_размер_формы);
            label1.Location = Форма.АвтоКорректор(label1.Location, this.Size, Старый_размер_формы);
            label2.Size = Форма.АвтоКорректор(label2.Size, this.Size, Старый_размер_формы);
            label2.Location = Форма.АвтоКорректор(label2.Location, this.Size, Старый_размер_формы);
            Текст.АвтоРазмерТекста(ref label1);
            Текст.АвтоРазмерТекста(ref label2);
            Старый_размер_формы = this.Size;
        }


        private void tabControl1_Layout(object sender, LayoutEventArgs e)
        {
            Архитектура_ЭВМ_Resize(((object)this), EventArgs.Empty);
        }
    }
}

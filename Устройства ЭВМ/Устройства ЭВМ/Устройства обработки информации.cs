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
    public partial class Устройства_обработки_информации : Form
    {
        public Устройства_обработки_информации()
        {
            InitializeComponent();
            label1.Text = "Процессор - это электронный блок либо интегральная схема (микропроцессор), исполняющая машинные инструкции (код программ), главная часть аппаратного обеспечения компьютера или программируемого логического контроллера.\n\n" +
                "Главными характеристиками процессора являются: тактовая частота, производительность, энергопотребление, нормы литографического процесса, используемого при производстве (для микропроцессоров) и архитектура.\n";
                //"Процессор - устройство, предназначенное для обработки информации и управления процессом обработки.\nОсновные характеристики процессора:\n1. быстродействие - число выполняемых операций   в единицу времени;\n2. разрядность - объем информации, которую процессор обрабатывает за одну операцию.";
            label2.Text = "Основными блоками процессора являются арифметико-логическое устройство (АЛУ), устройство управления (УУ) и несколько ячеек внутренней памяти - регистров. В регистрах хранятся команды, данные и адреса. АЛУ выполняет числовые и логические операции с данными в соответствии с кодом команды, хранящимся в регистре команд (сложение, сравнение и т.п.).\n" +
                "У с помощью набора управляющих сигналов организует согласованную работу всех блоков процессора и управляет как передачей адресов, команд и данных в процессоре по внутренней шине, так и взаимодействием процессора с \"внешним миром\".\n" +
                "Обобщенная структурная схема процессора содержит АЛУ, УУ и регистры выполняемые процессором команды образуют 5 классов:\n" +
                "   1. Команды управления системой\n" +
                "   2. Общие команды\n" +
                "   3. Команды для выполнения действий над числами с плавающей точкой\n" +
                "   4. Команды для выполнения действий над десятичными числами\n" +
                "   5. Команды ввода/вывода\n" +
                "Процессор может обращаться за информацией к 16 регистрам общего назначения (РОН). РОНы могут быть использованы в качестве накапливающих регистров в арифметических операциях с фиксированной точкой и в логических операциях, а также как индексные регистры в операциях над адресами. Каждый РОН имеет 32 разряда и задается в командах с помощью 4-битового поля R.\n" +
                "Для операций с плавающей точкой процессор имеет четыре 64-разрядных регистра. Они пронумерованы числами: 0,2,4,6. Эти регистры могут содержать как короткие 32-, так и длинные 64-битовые операнды с плавающей точкой. Короткие операнды занимают старшие биты регистра, а младшие биты не используются.\n" +
                "Имеются 3 класса операндов:\n" +
                "   1. регистровые операнды\n" +
                "   2. непосредственные операнды\n" +
                "   3. операнды в ОЗУ\n" +
                "Регистровые операнды размещаются в регистрах процессора, причем тип регистра определяется кодом операции, а номер регистра задается полем R команды.\n" +
                "Непосредственные операнды располагаются в самой команде, занимают 1 байт, который обозначается буквой I в поле команды.\n" +
                "Для обращения за операндом, находящимся в ОЗУ, используется либо адрес находящийся в одном из РОНов, либо адрес, который вычисляется по базовому адресу, индексу и смещению, обозначаемые в команде полями В, Х и Д.\n" +
                "\n"; ; 
                //"Основными блоками процессора являются арифметико-логическое устройство (АЛУ), устройство управления (УУ) и несколько ячеек внутренней памяти - регистров. В регистрах хранятся команды, данные и адреса. АЛУ выполняет числовые и логические операции с данными в соответствии с кодом команды, хранящимся в регистре команд (сложение, сравнение и т.п.). \nУ с помощью набора управляющих сигналов организует согласованную работу всех блоков процессора и управляет как передачей адресов, команд и данных в процессоре по внутренней шине, так и взаимодействием процессора с \"внешним миром\".";
            Старый_размер_формы = this.Size;
        }
        Size Старый_размер_формы;
        private void Устройства_обработки_информации_Resize(object sender, EventArgs e)
        {
            label1.Size = Форма.АвтоКорректор(label1.Size,this.Size,Старый_размер_формы);
            label1.Location = Форма.АвтоКорректор(label1.Location,this.Size,Старый_размер_формы);
            label2.Size = Форма.АвтоКорректор(label2.Size,this.Size,Старый_размер_формы);
            label2.Location = Форма.АвтоКорректор(label2.Location,this.Size,Старый_размер_формы);
            panel1.Size = Форма.АвтоКорректор(panel1.Size,this.Size,Старый_размер_формы);
            panel1.Location = Форма.АвтоКорректор(panel1.Location,this.Size,Старый_размер_формы);
            panel2.Size = Форма.АвтоКорректор(panel2.Size,this.Size,Старый_размер_формы);
            panel2.Location = Форма.АвтоКорректор(panel2.Location, this.Size, Старый_размер_формы);
            Текст.АвтоРазмерТекста(ref label1);
            Текст.АвтоРазмерТекста(ref label2, 4);
            Старый_размер_формы = this.Size;
        }

        private void tabControl1_Layout(object sender, LayoutEventArgs e)
        {
            Устройства_обработки_информации_Resize((object)this, EventArgs.Empty);
        }
    }
}

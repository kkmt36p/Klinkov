using System;
using System.Drawing;
using System.Windows.Forms;

namespace Библиотека_функций
{
    /// <summary>
    /// Класс работы с текстом
    /// </summary>
    public class Текст
    {
        /// <summary>
        /// Изменеие размера текста под размер формы
        /// </summary>
        /// <param name="lab"></param>
        /// <param name="conf">Переменная для более точной настроки корректора.
        /// Чем значение больше, тем меньше будит текст</param>
        public static void АвтоРазмерТекста(ref Label lab, double conf = 3)
        {
            float num = ((float)(Math.Sqrt((lab.Size.Height * lab.Size.Width) / (lab.Text.Length * conf))));
            lab.Font = new Font(lab.Font.Name, num > 0 ? num : (float)0.00001, lab.Font.Style, lab.Font.Unit);
        }
    }
    /// <summary>
    /// Класс работы с объектами в форме
    /// Условие для корректной работы: Свойство обектов Anchor = Top, Left
    /// </summary>
    public class Форма
    {
        /// <summary>
        /// Корректирует позицию и размер Label под размер формы
        /// </summary>
        /// <param name="Новый_размер_форма">Новый размер формы</param>
        /// <param name="Старый_размер_формы">Старый размер формы</param>
        /// <param name="Условие">Параметр Автокоректировки текста имеются "да"(по умолчанию) и "нет". Последующая цифра будит занесина в конфиг см. описание процедуры Текст.АвтоРазмерТекста</param>
        public static void АвтоКорректорОбъекта(ref Label Объект, Size Новый_размер_форма, Size Старый_размер_формы, string Условие = "да")
        {
            string[] Массив_условий = Условие.Split(' ');
            if (Массив_условий[0] == "да")
                if (Массив_условий.Length > 1)
                    Текст.АвтоРазмерТекста(ref Объект, double.Parse(Массив_условий[1]));
            else
                Текст.АвтоРазмерТекста(ref Объект);
            Объект.Size = АвтоКорректор(Объект.Size, Новый_размер_форма, Старый_размер_формы);
            Объект.Location = АвтоКорректор(Объект.Location, Новый_размер_форма, Старый_размер_формы);
        }
        /// <summary>
        /// Корректирует позицию и размер Panel под размер формы
        /// </summary>
        /// <param name="Объект"></param>
        /// <param name="Новый_размер_форма">Новый размер формы</param>
        /// <param name="Старый_размер_формы">Старый размер формы</param>
        public static void АвтоКорректорОбъекта(ref Panel Объект, Size Новый_размер_форма, Size Старый_размер_формы)
        {
            Объект.Size = АвтоКорректор(Объект.Size, Новый_размер_форма, Старый_размер_формы);
            Объект.Location = АвтоКорректор(Объект.Location, Новый_размер_форма, Старый_размер_формы);
        }
        /// <summary>
        /// Корректирует позицию и размер Button под размер формы
        /// </summary>
        /// <param name="Объект"></param>
        /// <param name="Новый_размер_форма">Новый размер формы</param>
        /// <param name="Старый_размер_формы">Старый размер формы</param>
        /// <param name="Условие">Доп. условия для размера. Имеются условия "Без_высоты" и "Без_ширины"</param>
        public static void АвтоКорректорОбъекта(ref Button Объект, Size Новый_размер_форма, Size Старый_размер_формы, string Условие = "")
        {
            Объект.Size = АвтоКорректор(Объект.Size, Новый_размер_форма, Старый_размер_формы, Условие);
            Объект.Location = АвтоКорректор(Объект.Location, Новый_размер_форма, Старый_размер_формы);
        }
        /// <summary>
        /// Корректирует позицию элемента под форму размеры которых будут предаставлен функции
        /// </summary>
        /// <param name="Позиция"></param>
        /// <param name="Новый_размер_форма"></param>
        /// <param name="Старый_размер_формы"></param>
        /// <returns></returns>
        public static Point АвтоКорректор(Point Позиция, Size Новый_размер_форма, Size Старый_размер_формы)
        {
            Позиция = new Point(Convert.ToInt32(Convert.ToDouble(Позиция.X) / Convert.ToDouble(Старый_размер_формы.Width) * Convert.ToDouble(Новый_размер_форма.Width)), Convert.ToInt32(Convert.ToDouble(Позиция.Y) / Convert.ToDouble(Старый_размер_формы.Height) * Convert.ToDouble(Новый_размер_форма.Height)));
            return Позиция;
        }
        /// <summary>
        /// Корректирует размер элемента под форму размеры которых будут предаставлен функции
        /// </summary>
        /// <param name="Размер">Размер элемента</param>
        /// <param name="Новый_размер_форма">Новый размер формы</param>
        /// <param name="Старый_размер_формы">Старый размер формы</param>
        /// <param name="Условие">Доп. условия имеются "Без_высоты" и "Без_ширины"</param>
        /// <returns></returns>
        public static Size АвтоКорректор(Size Размер, Size Новый_размер_форма, Size Старый_размер_формы, string Условие = "")
        {
            if (Условие == "Без_высоты")
                Размер = new Size(Convert.ToInt32(Convert.ToDouble(Размер.Width) / Convert.ToDouble(Старый_размер_формы.Width) * Convert.ToDouble(Новый_размер_форма.Width)), Размер.Height);
            else if (Условие == "Без_ширины")
                Размер = new Size(Размер.Width , Convert.ToInt32(Convert.ToDouble(Размер.Height) / Convert.ToDouble(Старый_размер_формы.Height) * Convert.ToDouble(Новый_размер_форма.Height)));
            else
                Размер = new Size(Convert.ToInt32(Convert.ToDouble(Размер.Width) / Convert.ToDouble(Старый_размер_формы.Width) * Convert.ToDouble(Новый_размер_форма.Width)), Convert.ToInt32(Convert.ToDouble(Размер.Height) / Convert.ToDouble(Старый_размер_формы.Height) * Convert.ToDouble(Новый_размер_форма.Height)));
            return Размер;
        }
    }
}
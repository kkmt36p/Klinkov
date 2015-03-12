using System;
using System.Drawing;
using System.Windows.Forms;

namespace Библиотека_функций
{
    public class Текст
    {
        public static void АвтоРазмерТекста(ref Label lab)
        {
            float num = ((float)(Math.Sqrt((lab.Size.Height * lab.Size.Width) / (lab.Text.Length * 3))));
            lab.Font = new Font(lab.Font.Name, num > 0 ? num : (float)0.00001, lab.Font.Style, lab.Font.Unit);
        }
    }
    public class Форма
    {
        public static Point АвтоКорректор(Point Позиция, Size Новый_размер_форма, Size Старый_размер_формы)
        {
            Позиция = new Point(Convert.ToInt32(Convert.ToDouble(Позиция.X) / Convert.ToDouble(Старый_размер_формы.Width) * Convert.ToDouble(Новый_размер_форма.Width)), Convert.ToInt32(Convert.ToDouble(Позиция.Y) / Convert.ToDouble(Старый_размер_формы.Height) * Convert.ToDouble(Новый_размер_форма.Height)));
            return Позиция;
        }
        public static Size АвтоКорректор(Size Размер, Size Новый_размер_форма, Size Старый_размер_формы)
        {
            Размер = new Size(Convert.ToInt32(Convert.ToDouble(Размер.Width) / Convert.ToDouble(Старый_размер_формы.Width) * Convert.ToDouble(Новый_размер_форма.Width)), Convert.ToInt32(Convert.ToDouble(Размер.Height) / Convert.ToDouble(Старый_размер_формы.Height) * Convert.ToDouble(Новый_размер_форма.Height)));
            return Размер;
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Библиотека_функций
{
    public class Текст
    {
        public static void АвтоРазмерТекста(ref Label lab)
        {
            /*while (lab.Text.Length * Math.Pow(lab.Font.Size, 2) * 3 < lab.Size.Height * lab.Size.Width)
                lab.Font = new Font(lab.Font.Name, lab.Font.Size + 1, lab.Font.Style, lab.Font.Unit);
            while (lab.Text.Length * Math.Pow(lab.Font.Size, 2) * 3 > lab.Size.Height * lab.Size.Width && lab.Font.Size > 1)
                lab.Font = new Font(lab.Font.Name, lab.Font.Size - 1, lab.Font.Style, lab.Font.Unit);*/
            float num = ((float)(Math.Sqrt((lab.Size.Height * lab.Size.Width) / (lab.Text.Length * 3))));
            lab.Font = new Font(lab.Font.Name, num > 0 ? num : (float)0.00001, lab.Font.Style, lab.Font.Unit);
        }
    }
    public class Форма
    {
        public static Point АвтоКорректор(Point Позиция, Size Новый_размер_форма, Size Старый_размер_формы)
        {
            ///   1200 500    600 250
            ///   1000 1000    500 500 
            ///   (double)   (int)
            double X = Старый_размер_формы.Width > Новый_размер_форма.Width ? ((double)Старый_размер_формы.Width / (double)Новый_размер_форма.Width) : (double)Новый_размер_форма.Width / (double)Старый_размер_формы.Width;
            double Y = Старый_размер_формы.Height > Новый_размер_форма.Height ? ((double)Старый_размер_формы.Height / (double)Новый_размер_форма.Height) : (double)Новый_размер_форма.Height / (double)Старый_размер_формы.Height;
            Позиция = new Point((int)(Старый_размер_формы.Width > Новый_размер_форма.Width ? (double)Позиция.X / X:(double)Позиция.X * X),
                (int)(Старый_размер_формы.Height > Новый_размер_форма.Height ? (double)Позиция.Y / Y : (double)Позиция.Y * Y));
            return Позиция;
        }
        public static Size АвтоКорректор(Size Размер, Size Новый_размер_форма, Size Старый_размер_формы)
        {
            double X = Старый_размер_формы.Width > Новый_размер_форма.Width ? ((double)Старый_размер_формы.Width / (double)Новый_размер_форма.Width) : (double)Новый_размер_форма.Width / (double)Старый_размер_формы.Width;
            double Y = Старый_размер_формы.Height > Новый_размер_форма.Height ? ((double)Старый_размер_формы.Height / (double)Новый_размер_форма.Height) : (double)Новый_размер_форма.Height / (double)Старый_размер_формы.Height;
            Размер = new Size((int)(Старый_размер_формы.Width > Новый_размер_форма.Width ? (double)Размер.Width / X : (double)Размер.Width * X),
                (int)(Старый_размер_формы.Height > Новый_размер_форма.Height ? (double)Размер.Height / Y : (double)Размер.Height * Y));
            return Размер;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Устройства_ЭВМ.Формы_Устр._хран._инфо
{
    public partial class Магнитные_ленты : Form
    {
        public Магнитные_ленты()
        {
            InitializeComponent();
            label1.Text = "Магнитная лента — носитель информации в виде гибкой ленты, покрытой тонким магнитным слоем. Информация на магнитной ленте фиксируется посредством магнитной записи.\n" +
            "Стример — запоминающее устройство на принципе магнитной записи на ленточном носителе, с последовательным доступом к данным, по принципу действия аналогичен бытовому магнитофону.";
        }
    }
}

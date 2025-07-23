using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private CarManager manager;

        internal Form2(CarManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            RaportDo();
        }

        private void CloseBtn(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RaportDo()
        {
            manager.Raport(available, rented, all);
        }
    }
}
